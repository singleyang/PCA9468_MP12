/*			pca9468_mp12_def.cpp
 *			Created: 2017/01/31
 *          Author: Yang Yin
 *        
 *			Contains global variables, helper functions and constants. 
 *			All together they make up a model of the pca9498's registers and 
 *			the data fields therein.
 */

#include "pca9468_mp12_def.h"
#include "pca9468_mp12_types.h"
#include <stdio.h>

#ifdef _DEBUG
//#define PCA9498_AUTO_INC          0x00
#define PCA9498_AUTO_INC          0x80
#define PCA9468_MP12_AUTO_INC			0x00
#else
#define PCA9498_AUTO_INC          0x80
#endif

pca_data_bits_t pca_data_bits_default[] = {
	/* 00 */ 0x18, 0x00, 0x00, 0x00, 
	/* 04 */ 0x00, 0x00, 0x00, 0x00, 
#ifdef _DEBUG
	/* 08 */ 0xF3FE, 0x8FF3, 0x3F8F,0xFC3F,
	/* 0C */ 0x03E0, 0x0F03, 0x380F,
#else
	/* 08 */ 0x0000, 0x0000, 0x0000, 0x0000,
	/* 0C */ 0x0000, 0x0000, 0x0000,
#endif
	/* 20 */ 0x3C, 0x9E, 0xB0, 0x02,
	/* 24 */ 0xFF, 0x01, 0x00, 0x7B,
	/* 28 */ 0x02, 0x03FF
};

/*************************************************************************************/
/*        Text feed functions for PCA9468(mp12)
/************************************************************************************/
void pca_tf_Three_bits(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 2) {
			sprintf_s(textbuffer, sz, "%03d", index);
		}
	}
}

void pca_tf_byte(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 5) {
			sprintf_s(textbuffer, sz, "0x%02X", index);
		}
	}
}
/*Enable/Disable check box*/
void pca_tf_En_Dis(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 9) {
			if (index == 0)
				sprintf_s(textbuffer, sz, "%s", "Enabled");
			else
				sprintf_s(textbuffer, sz, "%s", "Disabled");
		}
	}
}

/*snsres cmb*/
void pca_tf_sense_R(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 8) {
			if (index == 0)
				sprintf_s(textbuffer, sz, "%s", "5 mOhm");
			else
				sprintf_s(textbuffer, sz, "%s", "10 mOhm");
		}
	}
}

/*ichg_ss cmb*/
void pca_tf_ichg_ss(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 5) {
			if (index == 0)
				sprintf_s(textbuffer, sz, "%s", "0.5ms");
			else
				sprintf_s(textbuffer, sz, "%s", "2ms");
		}
	}
}

/*iin_ss cmb*/
void pca_tf_iin_ss(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 5) {
			if (index == 0)
				sprintf_s(textbuffer, sz, "%s", "2ms");
			else
				sprintf_s(textbuffer, sz, "%s", "60ms");
		}
	}
}

/*force_adc_mode cmb*/
void pca_tf_force_ADCmode(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 20) {
			switch (index)
			{
			case 0:
				sprintf_s(textbuffer, sz, "%s", "Do Not Force");
				break;
			case 1:
				sprintf_s(textbuffer, sz, "%s", "Force Normal Mode");
				break;
			case 2:
				sprintf_s(textbuffer, sz, "%s", "Force Hibernate Mode");
				break;
			default:
				sprintf_s(textbuffer, sz, "%s", "Force ShutDown Mode");
				break;
			}
		}
	}
}

/*adc_hib_delay cmb*/
void pca_tf_hib_delay(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 20) {
			switch (index)
			{
			case 0:
				sprintf_s(textbuffer, sz, "%s", "500ms");
				break;
			case 1:
				sprintf_s(textbuffer, sz, "%s", "1000ms");
				break;
			case 2:
				sprintf_s(textbuffer, sz, "%s", "2000ms");
				break;
			default:
				sprintf_s(textbuffer, sz, "%s", "4000ms");
				break;
			}
		}
	}
}

/*adc_offset_cfg cmb*/
void pca_tf_adcoffset_cfg(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 18) {
			if (index == 0)
				sprintf_s(textbuffer, sz, "%s", "Offset Subtraction");
			else
				sprintf_s(textbuffer, sz, "%s", "Chopping");
		}
	}
}

/*adcosr_cfg cmb*/
void pca_tf_adcosr_cfg(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 3) {
			if (index == 0)
				sprintf_s(textbuffer, sz, "%s", "32");
			else
				sprintf_s(textbuffer, sz, "%s", "64");
		}
	}
}

/*uv_delta cmb*/
void pca_tf_uv_delta(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 4) {
			switch (index)
			{
			case 0:
				sprintf_s(textbuffer, sz, "%s", "10%");
				break;
			case 1:
				sprintf_s(textbuffer, sz, "%s", "20%");
				break;
			case 2:
				sprintf_s(textbuffer, sz, "%s", "30%");
				break;
			default:
				sprintf_s(textbuffer, sz, "%s", "40%");
				break;
			}
		}
	}
}

/*watchdog_timer cfg cmb*/
void pca_tf_wtdogtmr_cfg(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 6) {
			switch (index)
			{
			case 0:
				sprintf_s(textbuffer, sz, "%s", "400ms");
				break;
			case 1:
				sprintf_s(textbuffer, sz, "%s", "800ms");
				break;
			case 2:
				sprintf_s(textbuffer, sz, "%s", "1600ms");
				break;
			default:
				sprintf_s(textbuffer, sz, "%s", "3200ms");
				break;
			}
		}
	}
}

/*charge timer cfg cmb*/
void pca_tf_chgtmr_cfg(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 7) {
			switch (index)
			{
			case 0:
				sprintf_s(textbuffer, sz, "%s", "20mins");
				break;
			case 1:
				sprintf_s(textbuffer, sz, "%s", "40mins");
				break;
			case 2:
				sprintf_s(textbuffer, sz, "%s", "80mins");
				break;
			default:
				sprintf_s(textbuffer, sz, "%s", "120mins");
				break;
			}
		}
	}
}

/*TempReg cmb*/
void pca_tf_temp_reg(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 6) {
			switch (index)
			{
			case 0:
				sprintf_s(textbuffer, sz, "%s", "90°C");
				break;
			case 1:
				sprintf_s(textbuffer, sz, "%s", "100°C");
				break;
			case 2:
				sprintf_s(textbuffer, sz, "%s", "110°C");
				break;
			default:
				sprintf_s(textbuffer, sz, "%s", "120°C");
				break;
			}
		}
	}
}

/*TempDelta cmb*/
void pca_tf_temp_delta(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 6) {
			switch (index)
			{
			case 0:
				sprintf_s(textbuffer, sz, "%s", "0°C");
				break;
			case 1:
				sprintf_s(textbuffer, sz, "%s", "5°C");
				break;
			case 2:
				sprintf_s(textbuffer, sz, "%s", "10°C");
				break;
			default:
				sprintf_s(textbuffer, sz, "%s", "15°C");
				break;
			}
		}
	}
}


/*ichg_cfg trackbar*/
void pca_tf_ichg_cfg(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 10) {
			if (index <= 80)
				sprintf_s(textbuffer, sz, "%dmA", index*100);
			else
				sprintf_s(textbuffer, sz, "%s", "Illegal value");
		}
	}
}

/*iin_cfg trackbar*/
void pca_tf_iin_cfg(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 10) {
			if (index <= 5)
				sprintf_s(textbuffer, sz, "%smA", "500");
			else if (index > 5 && index <= 0x32)
				sprintf_s(textbuffer, sz, "%dmA", index * 100);
			else
				sprintf_s(textbuffer, sz, "%s", "Illegal value");
		}
	}
}

/*sw_freq trackbar*/
void pca_tf_fsw_cfg(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 10) {
			if (index <= 0x0F)
				sprintf_s(textbuffer, sz, "%dkHz", 400 + index * 50);
			else
				sprintf_s(textbuffer, sz, "%s", "Illegal value");
		}
	}
}

/*V float trackbar*/
void pca_tf_V_float(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 10) {
			if (index <= 0xff)
			/*range from 3.725V - 5.000V with 5mV per step*/
			sprintf_s(textbuffer, sz, "%0.3fV", (3.725 + index * 0.005));
		}
	}
}

/*V float trackbar*/
void pca_tf_ntcvthres_set(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 10) {
			if (index <= 1023)
			/*range from 0mV - 2400mV with 2.3mV per step*/
			sprintf_s(textbuffer, sz, "%0.1fmV", (index * 2.3));
		}
	}
}


/*ADC Voltage text*/
void pca_tf_V_adc(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 10) {
			float val = (index & 0x1FFF);
			if ((index & 0x8000) == 0x8000) val *= -1;
			sprintf_s(textbuffer, sz, "%0.3fV", val / 1000);
		}
	}
}

/*ADC Current text*/
void pca_tf_A_adc(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 10) {
			float val = index & 0x1FFF;
			if ((index & 0x8000) == 0x8000) val *= -1;
			sprintf_s(textbuffer, sz, "%0.3fA", val / 1000);
		}
	}
}


/*ADC Temp text*/
void pca_tf_T_adc(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 10) {
			float val = index & 0x0FFF;
			if ((index & 0x8000) == 0x8000) val *= -1;
			sprintf_s(textbuffer, sz, "%0.3fV", val / 1000);
		}
	}
}

/*status Current text*/
void pca_tf_mA_adc(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 10) {
			float val = index & 0x1FFF;
			if ((index & 0x8000) == 0x8000) val *= -1;
			sprintf_s(textbuffer, sz, "%dmA", val);
		}
	}
}

void pca_tf_sts_adc(char *textbuffer, size_t sz, int index)
{
	if (textbuffer && sz > 0) {
		*textbuffer = '\0';
		if (sz >= 10) {
			int val = index & 0x3FF;
			sprintf_s(textbuffer, sz, "0x%x", val);
		}
	}
}


pca_data_field_t pca_DataFields[] = {
	/*25 Datafiled in total, all callbacks need to be reviewed YY*/
	/*Reg#,lsb,bitCnt,MaxVal,	Field index, Caption, textSupply function*/
	/*REG 0x00, Device Info*/
	{ 0x00, 0,  4,   0, dev_id, "Device ID",  pca_tf_Three_bits  },
	{ 0x00, 4,  4,   0, dev_rev, "Device Revision",  pca_tf_Three_bits  },
	/*REG 0x01, INT1 (RC) - (should read the INT1_STS for actual interrupt status)*/
	{ 0x01, 7,  1,   0, v_ok_int, "V OK INT",  pca_tf_En_Dis  },	
	{ 0x01, 6,	1,	 0, ntc_temp_int, "NTC TEMP INT", pca_tf_En_Dis },
	{ 0x01, 5,	1,   0, chg_phase_int, "CHG PHASE INT", pca_tf_En_Dis },
	{ 0x01, 4,	1,   0, pwr_collapse_int, "PWR COLLAPSE INT ", pca_tf_En_Dis },
	{ 0x01, 3,	1,   0, ctrl_limit_int, "CTRL LIMIT INT ", pca_tf_En_Dis },
	{ 0x01, 2,	1,   0, temp_reg_int, "TEMP REG INT ", pca_tf_En_Dis },
	{ 0x01, 1,	1,   0, adc_done_int, "ADC DONE INT ", pca_tf_En_Dis },
	{ 0x01, 0,	1,   0, timer_int, "TIMER INT ", pca_tf_En_Dis },
	/*REG 0x02, INT1_MASK (R/W)*/
	{ 0x02, 7, 1, 0, v_ok_m, "V OK Int mask", pca_tf_En_Dis },
	{ 0x02, 6, 1, 0, ntc_temp_m, "NTC temp Int mask", pca_tf_En_Dis },
	{ 0x02, 5, 1, 0, chg_phase_m, "Chg phase Int mask", pca_tf_En_Dis },
	{ 0x02, 4, 1, 0, pwr_collapse_m, "Pwr collaspe Int mask", pca_tf_En_Dis },
	{ 0x02, 3, 1, 0, ctrl_limit_m, "Ctrl limit Int mask", pca_tf_En_Dis },
	{ 0x02, 2, 1, 0, temp_reg_m, "Temp reg Int mask", pca_tf_En_Dis },
	{ 0x02, 1, 1, 0, adc_done_m, "Adc done Int mask", pca_tf_En_Dis },
	{ 0x02, 0, 1, 0, timer_m, "Timer Int mask", pca_tf_En_Dis },
	/*REG 0x03, INT1_STS (R)*/
	{ 0x03, 7, 1, 0, v_ok_sts, "V_OK status", pca_tf_En_Dis },
	{ 0x03, 6, 1, 0, ntc_temp_sts, "NTC temp status", pca_tf_En_Dis },
	{ 0x03, 5, 1, 0, chg_phase_sts, "CHG phrase status(NA)", pca_tf_En_Dis },
	{ 0x03, 4, 1, 0, pwr_collapse_sts, "Power collapse status", pca_tf_En_Dis },
	{ 0x03, 3, 1, 0, ctrl_limit_sts, "CTRL limit status", pca_tf_En_Dis },
	{ 0x03, 2, 1, 0, temp_reg_sts, "TEMP regulation status", pca_tf_En_Dis },
	{ 0x03, 1, 1, 0, adc_done_sts, "ADC done status", pca_tf_En_Dis },
	{ 0x03, 0, 1, 0, timer_sts, "Timer status", pca_tf_En_Dis },
	/*REG 0x04, STS_A (R)*/
	{ 0x04, 7, 1, 0, iin_loop_sts, "IIN loop status", pca_tf_En_Dis },
	{ 0x04, 6, 1, 0, chg_loop_sts, "ICHG loop status", pca_tf_En_Dis },
	{ 0x04, 5, 1, 0, vflt_loop_sts, "V_Float loop status", pca_tf_En_Dis },
	{ 0x04, 4, 1, 0, rsvd_1, "Reserved", pca_tf_En_Dis },
	{ 0x04, 3, 1, 0, vout_uv_sts, "VOut below V_OK status", pca_tf_En_Dis },
	{ 0x04, 2, 1, 0, vbat_ov_sts, "VBat above VBat_OVLO  ", pca_tf_En_Dis },
	{ 0x04, 1, 1, 0, vin_ov_sts, "VIn above VIn_OVLO", pca_tf_En_Dis },
	{ 0x04, 0, 1, 0, vin_uv_sts, "Ibus over current", pca_tf_En_Dis },
	/*REG 0x05, STS_B (R)*/
	{ 0x05, 7, 1, 0, batt_miss_sts, "Battery miss status", pca_tf_En_Dis },
	{ 0x05, 6, 1, 0, ocp_fast_sts, "Fast over current status", pca_tf_En_Dis },
	{ 0x05, 5, 1, 0, ocp_avg_sts, "Avarage over current status", pca_tf_En_Dis },
	{ 0x05, 4, 1, 0, active_state_sts, "Charge active status", pca_tf_En_Dis },
	{ 0x05, 3, 1, 0, shutdown_state_sts, "Charge shutdown status", pca_tf_En_Dis },
	{ 0x05, 2, 1, 0, standby_state_sts, "Charge standby status", pca_tf_En_Dis },
	{ 0x05, 1, 1, 0, charge_timer_sts, "Charge timer status", pca_tf_En_Dis },
	{ 0x05, 0, 1, 0, watchdog_timer_sts, "Watchdog timer status", pca_tf_En_Dis },
	/*REG 0x06, STS_C (R)*/
	{ 0x06, 2, 6, 0, iin_sts, "iin status", pca_tf_mA_adc },
	/*REG 0x07, STS_D (R)*/
	{ 0x07, 1, 7, 0, ichg_sts, "ICHG status", pca_tf_mA_adc },
	/*REG 0x08-0x10, STS_ADC_1-9 (R)*/ 
	{ 0x08, 0, 10, 0, adc_iin, "iin ADC", pca_tf_sts_adc },
	{ 0x09, 2, 10, 0, adc_iout, "Iout ADC", pca_tf_sts_adc },
	{ 0x0A, 4, 10, 0, adc_vin, "Vin ADC", pca_tf_sts_adc },
	{ 0x0B, 6, 10, 0, adc_vout, "Vout ADC", pca_tf_sts_adc },
	{ 0x0C, 0, 10, 0, adc_vbat, "Vbat ADC", pca_tf_sts_adc },
	{ 0x0D, 2, 10, 0, adc_dietemp, "DieTemp ADC", pca_tf_sts_adc },
	{ 0x0E, 4, 10, 0, adc_ntcv, "NTCV ADC", pca_tf_sts_adc },
	/*REG 0x20, ICHG_CTRL (R/W)*/
	{ 0x0F, 7, 1, 0, ichg_ss, "Charge Current Step Time", pca_tf_ichg_ss },
	{ 0x0F, 0, 7, 0x51, ichg_cfg, "Charge Current Set", pca_tf_ichg_cfg },
	/*REG 0x20, ICHG_CTRL (R/W)*/
	{ 0x10, 7, 1, 0, limit_increment_en, "Input Increment Enable", pca_tf_En_Dis },
	{ 0x10, 6, 1, 0, iin_ss, "Input Current Step Time", pca_tf_iin_ss },
	{ 0x10, 0, 6, 0x33, iin_cfg, "Input Current Set", pca_tf_iin_cfg },
	/*REG 0x22, START_CTRL (R/W)*/
	{ 0x11, 7, 1, 0, snsres, "Current Sense Resistance", pca_tf_sense_R },
	{ 0x11, 6, 1, 0, cfg_en, "Pin Active Low", pca_tf_En_Dis },
	{ 0x11, 5, 1, 0, standby_en, "Standby Mode", pca_tf_En_Dis },
	{ 0x11, 4, 1, 0, rev_iin_det, "Reverse Current Detection", pca_tf_En_Dis },
	{ 0x11, 0, 4, 0x10, fsw_cfg, "Switching Frequency", pca_tf_fsw_cfg },
	/*REG 0x23, ADC_CTRL (R/W)*/
	{ 0x12, 6, 2, 0, force_adc_mode, "ADC Mode Selection", pca_tf_force_ADCmode },
	{ 0x12, 3, 2, 0, hibernate_delay, "ADC Hibernate Delay", pca_tf_hib_delay },
	{ 0x12, 2, 1, 0, adc_offset_cfg, "ADC Offset Configration", pca_tf_adcoffset_cfg },
	{ 0x12, 1, 1, 0, adc_osr_cfg, "ADC Oscillator Select", pca_tf_adcosr_cfg },
	{ 0x12, 0, 1, 0, adc_en, "ADC Enable", pca_tf_En_Dis },
	/*REG 0x24, ADCCH_CFG (R/W)*/
	{ 0x13, 7, 1, 0, ch7_en, "NTC Voltage ADC", pca_tf_En_Dis },
	{ 0x13, 6, 1, 0, ch6_en, "Sys Voltage ADC", pca_tf_En_Dis },
	{ 0x13, 5, 1, 0, ch5_en, "Die Temp ADC", pca_tf_En_Dis },
	{ 0x13, 4, 1, 0, ch4_en, "Charge Current ADC", pca_tf_En_Dis },
	{ 0x13, 3, 1, 0, ch3_en, "Input Current ADC", pca_tf_En_Dis },
	{ 0x13, 2, 1, 0, ch2_en, "Battery Voltage ADC", pca_tf_En_Dis },
	{ 0x13, 1, 1, 0, ch1_en, "Input Voltage ADC", pca_tf_En_Dis },
	/*REG 0x25, TEMP_CTRL (R/W)*/
	{ 0x14, 6, 2, 0, temp_reg, "DieTemp Regulation", pca_tf_temp_reg },
	{ 0x14, 4, 2, 0, temp_delta, "DieTemp Regulation Delta", pca_tf_temp_delta },
	{ 0x14, 3, 1, 0, temp_reg_en, "DieTemp Regulation", pca_tf_En_Dis },
	{ 0x14, 2, 1, 0, ntc_protection_en, "Ext Thermistor Temp Protection", pca_tf_En_Dis },
	{ 0x14, 1, 1, 0, temp_max_en, "DieTemp Standby Mode", pca_tf_En_Dis },
	/*REG 0x26, PWR_COLLAPSE (R/W)*/
	{ 0x15, 6, 2, 0, uv_delta, "VIN UnderVoltage Setting", pca_tf_uv_delta },
	{ 0x15, 5, 1, 0, collapse_det_en, "Power Collapse Detection", pca_tf_En_Dis },
	{ 0x15, 4, 1, 0, iin_force_count, "Force IIN increment", pca_tf_En_Dis },
	{ 0x15, 3, 1, 0, bat_miss_det_en, "Battery Missing Detection", pca_tf_En_Dis },
	{ 0x15, 2, 1, 0, batt_miss_shdn_en, "Battery Missing Shutdown", pca_tf_En_Dis },
	/*REG 0x27, V_FLOAT (R/W)*/
	{ 0x16, 0, 8, 0, v_float, "V Float voltage set", pca_tf_V_float },
	/*REG 0x28, SAFETY_CTRL (R/W)*/
	{ 0x17, 7, 1, 0, watchdog_en, "Watchdog Timer En", pca_tf_En_Dis },
	{ 0x17, 5, 2, 0, watchdog_cfg, "Watchdog Timer Select", pca_tf_wtdogtmr_cfg },
	{ 0x17, 4, 1, 0, chg_timer_en, "Enable Charger Timer", pca_tf_En_Dis },
	{ 0x17, 2, 2, 0, chg_timer_cfg, "Charger Timer Select", pca_tf_chgtmr_cfg },
	{ 0x17, 0, 2, 0, ov_delta, "VIN Overvoltage Set", pca_tf_uv_delta },
	/*REG 0x29-0x2A, NTC_THRESHOLD_1(R/W)*/
	{ 0x18, 0, 10, 0x400, ntc_threshold, "Ext NTC Voltage Threshold", pca_tf_ntcvthres_set },
	/* Registers */
	{ 0x00, 0,  8,   0, reg_0, "DEV_INFO", pca_tf_byte },
	{ 0x01, 0,  8,   0, reg_1, "INT1", pca_tf_byte },
	{ 0x02, 0,  8,   0, reg_2, "INT1_MSK", pca_tf_byte },
	{ 0x03, 0,  8,   0, reg_3, "INT1_STS", pca_tf_byte },
	{ 0x04, 0,  8,   0, reg_4, "STS_A", pca_tf_byte },
	{ 0x05, 0,  8,   0, reg_5, "STS_B", pca_tf_byte },
	{ 0x06, 0,  8,   0, reg_6, "STS_C", pca_tf_byte },
	{ 0x07, 0,  8,   0, reg_7, "STS_D", pca_tf_byte },
	/*RegNo 0x08-0x0E each contains 16bits, while each STS_ADC used twice .*/
	{ 0x08, 0,  8,   0, reg_8, "STS_ADC_1", pca_tf_byte },
	{ 0x08, 8,	8,	 0, reg_9, "STS_ADC_2", pca_tf_byte },
	{ 0x09, 8,  8,   0, reg_a, "STS_ADC_3", pca_tf_byte },
	{ 0x0A, 8,  8,   0, reg_b, "STS_ADC_4", pca_tf_byte },
	{ 0x0B, 8,  8,   0, reg_c, "STS_ADC_5", pca_tf_byte },
	{ 0x0C, 0,  8,   0, reg_d, "STS_ADC_6", pca_tf_byte },
	{ 0x0C, 8,  8,   0, reg_e, "STS_ADC_7", pca_tf_byte },
	{ 0x0D, 8,  8,   0, reg_f, "STS_ADC_8", pca_tf_byte },
	{ 0x0E, 8,	6,	 0, reg_10, "STS_ADC_9", pca_tf_byte },
	{ 0x0F, 0,  8,   0, reg_20, "ICHG_CTRL", pca_tf_byte },
	{ 0x10, 0,  8,   0, reg_21, "IIN_CTRL", pca_tf_byte },
	{ 0x11, 0,  8,   0, reg_22, "START_CTRL", pca_tf_byte },
	{ 0x12, 0,  8,   0, reg_23, "ADC_CTRL", pca_tf_byte },
	{ 0x13, 0,  8,   0, reg_24, "ADC_CFG", pca_tf_byte },
	{ 0x14, 0,  8,   0, reg_25, "TEMP_CTRL", pca_tf_byte },
	{ 0x15, 0,  8,   0, reg_26, "PWR_COLLAPSE", pca_tf_byte },
	{ 0x16, 0,  8,   0, reg_27, "V_VFLOAT", pca_tf_byte },
	{ 0x17, 0,  8,   0, reg_28, "SAFETY_CTRL", pca_tf_byte },
	{ 0x18, 0,  8,   0, reg_29, "NTC_TH_1", pca_tf_byte },
	{ 0x18, 8,  2,   0, reg_2A, "NTC_TH_2", pca_tf_byte }
};

pca_register_t pca_registers[] = {
	{ true,  PCA9498_AUTO_INC | 0x00,  8, pca_data_bits_default[ 0] },
	{ true,  PCA9498_AUTO_INC | 0x01,  8, pca_data_bits_default[ 1] },
	{ false, PCA9498_AUTO_INC | 0x02,  8, pca_data_bits_default[ 2] },
	{ true,  PCA9498_AUTO_INC | 0x03,  8, pca_data_bits_default[ 3] },
	{ true,  PCA9498_AUTO_INC | 0x04,  8, pca_data_bits_default[ 4] },
	{ true,  PCA9498_AUTO_INC | 0x05,  8, pca_data_bits_default[ 5] },
	{ true,  PCA9498_AUTO_INC | 0x06,  8, pca_data_bits_default[ 6] },
	{ true,  PCA9498_AUTO_INC | 0x07,  8, pca_data_bits_default[ 7] },
	/*Special 16 bytes for ADC storage*/
	{ true,  PCA9498_AUTO_INC | 0x08, 16, pca_data_bits_default[8] },	/*STS_ADC_2|STS_ADC_1*/
	{ true,  PCA9498_AUTO_INC | 0x09, 16, pca_data_bits_default[9] },	/*STS_ADC_3|STS_ADC_2*/
	{ true,  PCA9498_AUTO_INC | 0x0A, 16, pca_data_bits_default[10] },	/*STS_ADC_4|STS_ADC_3*/
	{ true,  PCA9498_AUTO_INC | 0x0B, 16, pca_data_bits_default[11] },	/*STS_ADC_5|STS_ADC_4*/
	{ true,  PCA9498_AUTO_INC | 0x0D, 16, pca_data_bits_default[12] },	/*STS_ADC_7|STS_ADC_6*/
	{ true,  PCA9498_AUTO_INC | 0x0E, 16, pca_data_bits_default[13] },	/*STS_ADC_8|STS_ADC_7*/
	{ true,  PCA9498_AUTO_INC | 0x0F, 16, pca_data_bits_default[14] },	/*STS_ADC_9|STS_ADC_8*/
	/*Control Registers*/
	{ false, PCA9498_AUTO_INC | 0x20,  8, pca_data_bits_default[15] },
	{ false, PCA9498_AUTO_INC | 0x21,  8, pca_data_bits_default[16] },
	{ false, PCA9498_AUTO_INC | 0x22,  8, pca_data_bits_default[17] },
	{ false, PCA9498_AUTO_INC | 0x23,  8, pca_data_bits_default[18] },
	{ false, PCA9498_AUTO_INC | 0x24,  8, pca_data_bits_default[19] },
	{ false, PCA9498_AUTO_INC | 0x25,  8, pca_data_bits_default[20] },
	{ false, PCA9498_AUTO_INC | 0x26,  8, pca_data_bits_default[21] },
	{ false, PCA9498_AUTO_INC | 0x27,  8, pca_data_bits_default[22] },
	{ false, PCA9498_AUTO_INC | 0x28,  8, pca_data_bits_default[23] },
	{ false, PCA9498_AUTO_INC | 0x29,  16, pca_data_bits_default[24] },
};
