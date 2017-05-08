#include "pca9468_mp12.h"
#include "pca9468_mp12_def.h"
#include <stdlib.h>
#include <vector>
#include "../pca9498_com/pca9498_com.h"

/* ==================================================================
 *
 * Global variables
 *
 * ==================================================================*/

std::vector<pca_notify_function_t> gCallbacks;
extern pca_data_field_t pca_DataFields[];
extern pca_register_t pca_registers[];
//slave address for MP12
//uint8_t gSla = 0x53; //ADD = 'H'
//uint8_t gSla = 0x57; //ADD = 'L'
//uint8_t gSla = 0x5E; //ADD = 'High-Z'

uint8_t gSla = 0x66;

/* ==================================================================
 *
 * Local functions and macro's
 *
 * ==================================================================*/

#define DATAFIELD(d) pca_DataFields[d]
#define VALUECOUNT(d) (2 << (DATAFIELD(d).bit_count-1))
#define MASK(d) ((VALUECOUNT(d)-1)<<DATAFIELD(d).ls_bit)

bool pcaCallbackExists(pca_notify_function_t callback, int *iterator = NULL) {
	unsigned int idx;
	for (idx = 0; idx < gCallbacks.size(); idx++) {
		if (gCallbacks[idx] == callback) {
			if (iterator) *iterator = idx;
			return true;
		}
	}
	return false;
}

 void Notify(pca_data_fields_enum_t field, pca_notify_t result) {
	unsigned int idx;
	size_t cnt = gCallbacks.size();
	for (idx = 0; idx < cnt; idx++) {
		gCallbacks[idx](field, result);
	}
}

uint16_t _pcaSetRegister(int regNumber, int value) {
	uint16_t delta = 0;
	if (regNumber >= 0 && regNumber < PCA9468_MP12_REG_COUNT) {
		uint16_t oldvalue = pca_registers[regNumber].data_bits;
		pca_registers[regNumber].data_bits = value & 0xFFFF;
		delta = oldvalue ^ pca_registers[regNumber].data_bits;
		if (delta != 0) {
			// some bit(s) changed. Notify the caller which data fields have changed
			unsigned int idx = 0;
			//for (idx = 0; idx < number_of_dataFields; idx++) {
			//	if (pca_DataFields[idx].regnum == regNumber) break;
			//}
			for (; idx < number_of_dataFields; idx++) {
				if (pca_DataFields[idx].regnum != regNumber) continue;
				if ((MASK(idx) & delta) != 0) {
					Notify(static_cast<pca_data_fields_enum_t>(idx), pr_ok);
					//break;
				}
			}
		}
	}
	return delta;
}

uint16_t _pcaSetRegisterSwapped(int regNumber, int value) {
	int swapped = 0;
	int bytecount = pca_registers[regNumber].bitSz / 8;
	if (bytecount == 1) {
		swapped = value;
	}
	if (bytecount == 2) {
		swapped = ((value & 0x00FF) << 8) + ((value & 0xFF00) >> 8); 
	}
	if (bytecount == 3) {
		swapped = ((value & 0x0000FF) << 16) + ((value & 0x00FF00) >> 0) + ((value & 0xFF0000) >> 16); 
	}
	if (bytecount == 4) {
		swapped = ((value & 0x000000FF) << 24) + ((value & 0x0000FF00) << 8) + ((value & 0x00FF0000) >> 8) + ((value & 0xFF000000) >> 24); 
	}
	return _pcaSetRegister(regNumber, swapped);
}

/* ==================================================================
 *
 * Exported functions
 *
 * ==================================================================*/

pca_result_t pcaGetCaption(pca_data_fields_enum_t dataField, char *textbuffer, size_t sz)
{
	if (dataField >= 0 && dataField < number_of_dataFields) {
		strcpy_s(textbuffer, sz, DATAFIELD(dataField).caption);
		return pca_ok;
	}
	return pca_badParam;
}

int pcaGetValueCount(pca_data_fields_enum_t dataField) {
	if (dataField < 0 || dataField >= number_of_dataFields) return -1;
	if (DATAFIELD(dataField).value_count != 0) return DATAFIELD(dataField).value_count;
	return VALUECOUNT(dataField);
}

int pcaGetValueText(pca_data_fields_enum_t dataField, int Index, char *textbuffer, size_t sz) {
	if (dataField < 0 || dataField >= number_of_dataFields) return 0;
	if (Index < 0 || Index >= VALUECOUNT(dataField)) return 0;
	if (DATAFIELD(dataField).value_text_func != NULL) 
		DATAFIELD(dataField).value_text_func(textbuffer, sz, Index);
	return 1;
}

int pcaGetCurrentValue(pca_data_fields_enum_t dataField) {
	if (dataField < 0 || dataField >= number_of_dataFields) return NULL;
	pca_data_field_t *datafld = &DATAFIELD(dataField);
	pca_data_bits_t data = pca_registers[datafld->regnum].data_bits;
	return (data >> datafld->ls_bit) & ((1 << (datafld->bit_count - 0)) - 1);
}

int pcaGetCurrentText(pca_data_fields_enum_t dataField, char *textbuffer, size_t sz) {
	int currentValue = pcaGetCurrentValue(dataField);
	if (currentValue >= 0) 
		 if (DATAFIELD(dataField).value_text_func != NULL) 
			 DATAFIELD(dataField).value_text_func(textbuffer, sz, currentValue);
	return currentValue >= 0;
}

//int pcaGetValueForText(pca_data_fields_enum_t dataField, const char *txt) {
//	// No way to predict the value. Can't use a binary search either. 
//
//
//}

uint8_t _pcaGetRegVal8(int regNumber) {
	// Notice PCA9498 has only 8 bit writable registers
	return (uint8_t) pcaGetRegisterValue(regNumber) & 0xFF;
}

int pcaGetRegisterValue(int regnumber)
{
	if (regnumber >= 0 && regnumber < PCA9468_MP12_REG_COUNT) 
		return pca_registers[regnumber].data_bits;
	return -1;
}

/* Returns zero if the register is writable */
int pcaIsRegisterReadOnly(int regnumber)
{
	if (regnumber >= 0 && regnumber < PCA9468_MP12_REG_COUNT) 
		return pca_registers[regnumber].readonly;
	return true;
}

/* Returns zero if the datafield is writable */
int pcaIsDataFieldReadOnly(pca_data_fields_enum_t dataField)
{
	return pcaIsRegisterReadOnly(pca_DataFields[dataField].regnum);
}

void pcaRegisterNotification(pca_notify_function_t callback) {
	if (!pcaCallbackExists(callback)) {
		gCallbacks.push_back(callback);
	}
}

void pcaUnregisterNotification(pca_notify_function_t callback) {
	int iterator;
	if (pcaCallbackExists(callback, &iterator)) 
		gCallbacks.erase (gCallbacks.begin() + iterator);
}

pca_result_t pcaReadDataField(pca_data_fields_enum_t dataField) {
	if (dataField >= 0 && dataField < number_of_dataFields) {
		return pcaReadRegister(DATAFIELD(dataField).regnum);
	}
	else Notify(dataField, pr_badparam);
	return pca_badParam;
}

pca_result_t pcaReadRegister(int regNumber) {
	uint16_t data;
	pca_result_t result;
	if (regNumber < 0 || regNumber >= PCA9468_MP12_REG_COUNT) return pca_badParam;
	if ((result = (pca_result_t)pc_readRegister(gSla, 
												pca_registers[regNumber].offset, 
												(uint8_t *) &data, 
												pca_registers[regNumber].bitSz / 8)
												) == pca_ok)
	{
		_pcaSetRegisterSwapped(regNumber, data);
	}
	return result;
}

pca_result_t pcaReadRegisters(int regNumber, int count) {
	pca_result_t result = pca_ok;
	int idx;
	int bytecount = 0;
	for (idx = regNumber; idx < regNumber + count; idx++) {
		bytecount += pca_registers[idx].bitSz / 8;
	}
	uint8_t data[0xFF];
	/*Check whether auto incremental(0x00) need to to changed */
	if ((result = (pca_result_t)pc_readRegister(gSla, pca_registers[regNumber].offset, (uint8_t *) &data, bytecount)) == pca_ok)
	{
		bytecount = 0;
		for (idx = regNumber; idx < regNumber + count; idx++) {
			_pcaSetRegisterSwapped(idx, *((int *)&data[bytecount]));
			bytecount += pca_registers[idx].bitSz / 8;
		}
		
	}
	return result;
}

/*This function needs to be rewrite for MP12 ADC reading*/
pca_result_t pcaReadADCRegisters(int regNumber, int count) {
	pca_result_t result = pca_ok;
	int idx;
	int bytecount = 0;
	for (idx = regNumber; idx < regNumber + count; idx++) {
		bytecount += pca_registers[idx].bitSz / 16;
	}
	uint8_t data[0xFF];
#if 0
	{
		data[0] =  0xAA;
		data[1] =  0xBB;
		data[2] =  0xCC;
		data[3] =  0xDD;
		data[4] =  0xEE;
		data[5] =  0xFF;
		data[6] =  0x11;
		data[7] =  0xCC;
		data[8] =  0xBC;
#else
	/*Check whether auto incremental(0x80) need to to changed */
	if ((result = (pca_result_t)pc_readRegister(gSla, pca_registers[regNumber].offset, (uint8_t *)&data, 9)) == pca_ok)
	{
#endif	
		int value;
		/*STS_ADC_2|STS_ADC_1*/
		value = ((*(int *)&data[1] & 0x00FF) << 8) |(*(int *)&data[0] & 0x00FF);
		_pcaSetRegister(0x08, value);
		/*STS_ADC_3|STS_ADC_2*/
		value = ((*(int *)&data[2] & 0x00FF) << 8) | (*(int *)&data[1] & 0x00FF);
		_pcaSetRegister(0x09, value);
		/*STS_ADC_4|STS_ADC_3*/
		value = ((*(int *)&data[3] & 0x00FF) << 8) | (*(int *)&data[2] & 0x00FF);
		_pcaSetRegister(0x0A, value);
		/*STS_ADC_5|STS_ADC_4*/
		value = ((*(int *)&data[4] & 0x00FF) << 8) | (*(int *)&data[3] & 0x00FF);
		_pcaSetRegister(0x0B, value);
		/*STS_ADC_7|STS_ADC_6*/
		value = ((*(int *)&data[6] & 0x00FF) << 8) | (*(int *)&data[5] & 0x00FF);
		_pcaSetRegister(0x0C, value);
		/*STS_ADC_8|STS_ADC_7*/
		value = ((*(int *)&data[7] & 0x00FF) << 8) | (*(int *)&data[6] & 0x00FF);
		_pcaSetRegister(0x0D, value);
		/*STS_ADC_9|STS_ADC_8*/
		value = ((*(int *)&data[8] & 0x00FF) << 8) | (*(int *)&data[7] & 0x00FF);
		_pcaSetRegister(0x0E, value);
	}
	return result;
}

/*This function is modified for MP12*/
pca_result_t pcaReadAll() {
	pca_result_t result = pca_ok;
	/*Read out Interrupt and Status Regs 0x00-0x10 (RegNo 00-16)*/
	if ((result = pcaReadRegisters(00, 8)) == pca_ok)
	{
		if ((result = pcaReadADCRegisters(8, 9)) == pca_ok)
		{
			/*Read out Interrupt and Status Regs 0x20-0x2A (11 Registers)*/
			result = pcaReadRegisters(17, 11);
		}
	}
	return result;
}

pca_result_t pcaSetRegisterAndWrite(int regNumber, int value) {
	if (_pcaSetRegister(regNumber, value) != 0) 
		return pcaWriteRegister(regNumber);
	return pca_ok;
}

pca_result_t pcaSetDataField(pca_data_fields_enum_t dataField, int value) {
	uint16_t newvalue;
	int regnumber;
	if (dataField >= 0 && dataField < number_of_dataFields) {
		regnumber = DATAFIELD(dataField).regnum;
		newvalue = pcaGetRegisterValue(regnumber) & ~MASK(dataField);
		newvalue |= ((value << DATAFIELD(dataField).ls_bit) & MASK(dataField));
		//return pcaSetRegisterAndWrite(regnumber, newvalue);
		pcaSetRegister(regnumber, newvalue);
		return pca_ok;
	}
	return pca_badParam;
}

void pcaSetRegister(int regNumber, int value) {
	_pcaSetRegister(regNumber, value);
}

pca_result_t pcaWriteDataField(pca_data_fields_enum_t dataField) {
	if (dataField >= 0 && dataField < number_of_dataFields)
		return pcaWriteRegister(DATAFIELD(dataField).regnum);
	return pca_badParam;
}

pca_result_t pcaWriteRegister(int regNumber) {
	pca_result_t result = pca_ok;
	// ...
	if (result == pca_ok) 
		result = (pca_result_t)pc_writeRegister(gSla, 
												pca_registers[regNumber].offset,
												(uint8_t *)&pca_registers[regNumber].data_bits,
												1);
	return result;
}

/*MP12 write dbg registers*/
pca_result_t pcaDbgWriteRegister(int regAddr, int val)
{
	return (pca_result_t)pc_writeRegister(gSla, regAddr&0xFF, (uint8_t *)&val, 1);
}

/*MP12 write dbg registers*/
int pcaDbgReadRegister(int regAddr)
{
	uint8_t readRegVal = 0;
	if ((pca_result_t)pc_readRegister(gSla, regAddr & 0xFF, &readRegVal, 1) == pca_ok)
	{
		return readRegVal;
	}
	else
	{ 
		/*special return code*/
		return 0xF0F0F000;
	}
}

pca_result_t pcaWriteAll() {
	pca_result_t result = pca_ok;
	unsigned int idx, offset;
	uint8_t data[0xFF];
	offset = 0;
	
	/*Write Int Mask 0x02*/
	idx = 2;
	data[offset++] = (pca_registers[idx].data_bits & 0xFF);
	result = pc_writeRegister(gSla, 0x02, data, 1) == pc_ok ? pca_ok : pca_writeFailed;
	
	/*Write Config Reg 0x20-0x2A (11 regs)*/
	if (result == pca_ok) {
		offset = 0;
		/*Write Config Reg 0x20-0x28*/
		for (idx = 15; idx < 24; idx++) {
			data[offset++] = (pca_registers[idx].data_bits & 0xFF);
		}
		/*Write Config Reg 0x29-0x2A*/
		data[offset++] = (pca_registers[24].data_bits) >> 8 & 0xFF;
		data[offset++] = (pca_registers[24].data_bits) & 0xFF;
		result = pc_writeRegister(gSla, 0x20, data, 11) == pc_ok ? pca_ok : pca_writeFailed;
	}
	return result;
}

pca_result_t pcaSetAndWriteDataField(pca_data_fields_enum_t dataField, int value) {
	pcaSetDataField(dataField, value);
	return pcaWriteDataField(dataField);
}

pca_result_t pcaSetAndWriteRegister(int regNumber, int value) {
	pcaSetRegister(regNumber, value);
	return pcaWriteRegister(regNumber);
}

void pcaSlaveAddress(int sla) {
	gSla = (uint8_t)(sla & 0xFF);
}
