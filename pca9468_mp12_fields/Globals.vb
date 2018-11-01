' Enumeration for all data fields
Public Enum pca_data_fields_enum_t
    'REG 0x00, Device Info'
	dev_id
    dev_rev
    'REG 0x01, INT1 (RC)'
    v_ok_int
    ntc_temp_int
    chg_phase_int
    pwr_collapse_int
    ctrl_limit_int
    temp_reg_int
    adc_done_int
    timer_int
    'REG 0x02, INT1_MASK (R/W)
    v_ok_m
    ntc_temp_m
    chg_phase_m
    pwr_collapse_m
    ctrl_limit_m
    temp_reg_m
    adc_done_m
    timer_m
    'REG 0x03, INT1_STS (R)
    v_ok_sts
    ntc_temp_sts
    chg_phase_sts
    pwr_collapse_sts
    ctrl_limit_sts
    temp_reg_sts
    adc_done_sts
    timer_sts
    'REG 0x04, STS_A (R)
    iin_loop_sts
    chg_loop_sts
    vflt_loop_sts
    cfly_short_sts
    vout_uv_sts
    vbat_ov_sts
    vin_ov_sts
    vin_uv_sts
    'REG 0x05, STS_B (R)
    batt_miss_sts
    ocp_fast_sts
    ocp_avg_sts
    active_state_sts
    shutdown_state_sts
    standby_state_sts
    charge_timer_sts
    watchdog_timer_sts
    'REG 0x06, STS_C (R)
    iin_sts
    'REG 0x07, STS_D (R)
    ichg_sts
    'REG 0x08-0x10, STS_ADC_1-9 (R)
    adc_iin
    adc_iout
    adc_vin
    adc_vout
    adc_vbat
    adc_dietemp
    adc_ntcv
    'REG 0x20, ICHG_CTRL (R/W)
    ichg_ss
    ichg_cfg
    'REG 0x21, IIN_CTRL (R/W)
    limit_increment_en
    iin_ss
    iin_cfg
    'REG 0x22, START_CTRL (R/W)
    snsres
    cfg_en
    standby_en
    rev_iin_det
    fsw_cfg
    'REG 0x23, ADC_CTRL (R/W)
    force_adc_mode
    adc_shutdown_cfg
    hibernate_delay
    sc_clk_dither_rate     'added in B0
    'REG 0x24, ADCCH_CFG (R/W) 
    'modified according to v1.0 spec
    ntc_adc_en
    dietemp_adc_en
    iin_adc_en
    chgcurrent_adc_en
    vbat_adc_en
    vin_adc_en
    sysV_adc_en
    'REG 0x25, TEMP_CTRL (R/W)
    temp_reg
    temp_delta
    temp_reg_en
    ntc_protection_en
    temp_max_en
    sc_clk_dither_en    'added in B0
    'REG 0x26, PWR_COLLAPSE (R/W)
    uv_delta
    collapse_det_en
    iin_force_count
    bat_miss_det_en
    unplug_force_standby 'added in B0
    'REG 0x27, V_FLOAT (R/W)
    v_float
    'REG 0x28, SAFETY_CTRL (R/W)
    watchdog_en
    watchdog_cfg
    chg_timer_en
    chg_timer_cfg
    ov_delta
    'REG 0x29-0x2A, NTC_THRESHOLD_1(R/W)
    sc_clk_dither_limit  'added in B0
    ntc_threshold
    'registers
    reg_0
    reg_1
    reg_2
    reg_3
    reg_4
    reg_5
    reg_6
    reg_7
    reg_8
    reg_9
    reg_a
    reg_b
    reg_c
    reg_d
    reg_e
    reg_f
    reg_10
    reg_20
    reg_21
    reg_22
    reg_23
    reg_24
    reg_25
    reg_26
    reg_27
    reg_28
    reg_29
    reg_2A
    number_of_dataFields
End Enum

Module Globals

End Module
