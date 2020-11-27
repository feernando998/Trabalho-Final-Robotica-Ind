;  Assembly code generated by mikroVirtualMachine - V. 5.0.0.3
;  Date/Time: 26/11/2020 21:37:02
;  Info: http://www.mikroe.com


; ADDRESS	OPCODE	ASM
; ----------------------------------------------
$0000	$2972			GOTO	_main
$0004	$	_pulso:
;ControleMotor5e6.pbas,13 :: 		sub procedure pulso(dim motor as integer, dim inverte as boolean)
;ControleMotor5e6.pbas,15 :: 		if revolucao = true then
$0004	$1303			BCF	STATUS, RP1
$0005	$1283			BCF	STATUS, RP0
$0006	$0820			MOVF	_revolucao, 0
$0007	$3AFF			XORLW	255
$0008	$1D03			BTFSS	STATUS, Z
$0009	$28E6			GOTO	ControleMotor5e6_L_2
$000A	$	ControleMotor5e6_L_1:
;ControleMotor5e6.pbas,16 :: 		if inverte = false then
$000A	$082A			MOVF	FARG_pulso+2, 0
$000B	$3A00			XORLW	0
$000C	$1D03			BTFSS	STATUS, Z
$000D	$2820			GOTO	ControleMotor5e6_L_5
$000E	$	ControleMotor5e6_L_4:
;ControleMotor5e6.pbas,17 :: 		dec(passo)
$000E	$3001			MOVLW	1
$000F	$02A1			SUBWF	_passo, 1
$0010	$1C03			BTFSS	STATUS, C
$0011	$03A2			DECF	_passo+1, 1
;ControleMotor5e6.pbas,18 :: 		if passo < 1 then
$0012	$3080			MOVLW	128
$0013	$0622			XORWF	_passo+1, 0
$0014	$00F0			MOVWF	STACK_0
$0015	$3080			MOVLW	128
$0016	$0270			SUBWF	STACK_0, 0
$0017	$1D03			BTFSS	STATUS, Z
$0018	$281B			GOTO	L_pulso_0
$0019	$3001			MOVLW	1
$001A	$0221			SUBWF	_passo, 0
$001B	$	L_pulso_0:
$001B	$1803			BTFSC	STATUS, C
$001C	$2820			GOTO	ControleMotor5e6_L_8
$001D	$	ControleMotor5e6_L_7:
;ControleMotor5e6.pbas,19 :: 		passo=8
$001D	$3008			MOVLW	8
$001E	$00A1			MOVWF	_passo
$001F	$01A2			CLRF	_passo+1
$0020	$	ControleMotor5e6_L_8:
;ControleMotor5e6.pbas,20 :: 		end if
$0020	$	ControleMotor5e6_L_9:
$0020	$	ControleMotor5e6_L_5:
;ControleMotor5e6.pbas,21 :: 		end if
$0020	$	ControleMotor5e6_L_6:
;ControleMotor5e6.pbas,22 :: 		if inverte = true then
$0020	$082A			MOVF	FARG_pulso+2, 0
$0021	$3AFF			XORLW	255
$0022	$1D03			BTFSS	STATUS, Z
$0023	$2835			GOTO	ControleMotor5e6_L_11
$0024	$	ControleMotor5e6_L_10:
;ControleMotor5e6.pbas,23 :: 		inc(passo)
$0024	$0AA1			INCF	_passo, 1
$0025	$1903			BTFSC	STATUS, Z
$0026	$0AA2			INCF	_passo+1, 1
;ControleMotor5e6.pbas,24 :: 		if passo > 8 then
$0027	$3080			MOVLW	128
$0028	$00F0			MOVWF	STACK_0
$0029	$3080			MOVLW	128
$002A	$0622			XORWF	_passo+1, 0
$002B	$0270			SUBWF	STACK_0, 0
$002C	$1D03			BTFSS	STATUS, Z
$002D	$2830			GOTO	L_pulso_1
$002E	$0821			MOVF	_passo, 0
$002F	$3C08			SUBLW	8
$0030	$	L_pulso_1:
$0030	$1803			BTFSC	STATUS, C
$0031	$2835			GOTO	ControleMotor5e6_L_14
$0032	$	ControleMotor5e6_L_13:
;ControleMotor5e6.pbas,25 :: 		passo=1
$0032	$3001			MOVLW	1
$0033	$00A1			MOVWF	_passo
$0034	$01A2			CLRF	_passo+1
$0035	$	ControleMotor5e6_L_14:
;ControleMotor5e6.pbas,26 :: 		end if
$0035	$	ControleMotor5e6_L_15:
$0035	$	ControleMotor5e6_L_11:
;ControleMotor5e6.pbas,27 :: 		end if
$0035	$	ControleMotor5e6_L_12:
;ControleMotor5e6.pbas,29 :: 		if motor = 1 then
$0035	$3000			MOVLW	0
$0036	$0629			XORWF	FARG_pulso+1, 0
$0037	$1D03			BTFSS	STATUS, Z
$0038	$283B			GOTO	L_pulso_2
$0039	$3001			MOVLW	1
$003A	$0628			XORWF	FARG_pulso, 0
$003B	$	L_pulso_2:
$003B	$1D03			BTFSS	STATUS, Z
$003C	$288D			GOTO	ControleMotor5e6_L_17
$003D	$	ControleMotor5e6_L_16:
;ControleMotor5e6.pbas,30 :: 		if passo=1 then PORTC=9 end if
$003D	$3000			MOVLW	0
$003E	$0622			XORWF	_passo+1, 0
$003F	$1D03			BTFSS	STATUS, Z
$0040	$2843			GOTO	L_pulso_3
$0041	$3001			MOVLW	1
$0042	$0621			XORWF	_passo, 0
$0043	$	L_pulso_3:
$0043	$1D03			BTFSS	STATUS, Z
$0044	$2847			GOTO	ControleMotor5e6_L_20
$0045	$	ControleMotor5e6_L_19:
$0045	$3009			MOVLW	9
$0046	$0087			MOVWF	PORTC
$0047	$	ControleMotor5e6_L_20:
$0047	$	ControleMotor5e6_L_21:
;ControleMotor5e6.pbas,31 :: 		if passo=2 then PORTC=8 end if
$0047	$3000			MOVLW	0
$0048	$0622			XORWF	_passo+1, 0
$0049	$1D03			BTFSS	STATUS, Z
$004A	$284D			GOTO	L_pulso_4
$004B	$3002			MOVLW	2
$004C	$0621			XORWF	_passo, 0
$004D	$	L_pulso_4:
$004D	$1D03			BTFSS	STATUS, Z
$004E	$2851			GOTO	ControleMotor5e6_L_23
$004F	$	ControleMotor5e6_L_22:
$004F	$3008			MOVLW	8
$0050	$0087			MOVWF	PORTC
$0051	$	ControleMotor5e6_L_23:
$0051	$	ControleMotor5e6_L_24:
;ControleMotor5e6.pbas,32 :: 		if passo=3 then PORTC=12 end if
$0051	$3000			MOVLW	0
$0052	$0622			XORWF	_passo+1, 0
$0053	$1D03			BTFSS	STATUS, Z
$0054	$2857			GOTO	L_pulso_5
$0055	$3003			MOVLW	3
$0056	$0621			XORWF	_passo, 0
$0057	$	L_pulso_5:
$0057	$1D03			BTFSS	STATUS, Z
$0058	$285B			GOTO	ControleMotor5e6_L_26
$0059	$	ControleMotor5e6_L_25:
$0059	$300C			MOVLW	12
$005A	$0087			MOVWF	PORTC
$005B	$	ControleMotor5e6_L_26:
$005B	$	ControleMotor5e6_L_27:
;ControleMotor5e6.pbas,33 :: 		if passo=4 then PORTC=4 end if
$005B	$3000			MOVLW	0
$005C	$0622			XORWF	_passo+1, 0
$005D	$1D03			BTFSS	STATUS, Z
$005E	$2861			GOTO	L_pulso_6
$005F	$3004			MOVLW	4
$0060	$0621			XORWF	_passo, 0
$0061	$	L_pulso_6:
$0061	$1D03			BTFSS	STATUS, Z
$0062	$2865			GOTO	ControleMotor5e6_L_29
$0063	$	ControleMotor5e6_L_28:
$0063	$3004			MOVLW	4
$0064	$0087			MOVWF	PORTC
$0065	$	ControleMotor5e6_L_29:
$0065	$	ControleMotor5e6_L_30:
;ControleMotor5e6.pbas,34 :: 		if passo=5 then PORTC=6 end if
$0065	$3000			MOVLW	0
$0066	$0622			XORWF	_passo+1, 0
$0067	$1D03			BTFSS	STATUS, Z
$0068	$286B			GOTO	L_pulso_7
$0069	$3005			MOVLW	5
$006A	$0621			XORWF	_passo, 0
$006B	$	L_pulso_7:
$006B	$1D03			BTFSS	STATUS, Z
$006C	$286F			GOTO	ControleMotor5e6_L_32
$006D	$	ControleMotor5e6_L_31:
$006D	$3006			MOVLW	6
$006E	$0087			MOVWF	PORTC
$006F	$	ControleMotor5e6_L_32:
$006F	$	ControleMotor5e6_L_33:
;ControleMotor5e6.pbas,35 :: 		if passo=6 then PORTC=2 end if
$006F	$3000			MOVLW	0
$0070	$0622			XORWF	_passo+1, 0
$0071	$1D03			BTFSS	STATUS, Z
$0072	$2875			GOTO	L_pulso_8
$0073	$3006			MOVLW	6
$0074	$0621			XORWF	_passo, 0
$0075	$	L_pulso_8:
$0075	$1D03			BTFSS	STATUS, Z
$0076	$2879			GOTO	ControleMotor5e6_L_35
$0077	$	ControleMotor5e6_L_34:
$0077	$3002			MOVLW	2
$0078	$0087			MOVWF	PORTC
$0079	$	ControleMotor5e6_L_35:
$0079	$	ControleMotor5e6_L_36:
;ControleMotor5e6.pbas,36 :: 		if passo=7 then PORTC=3 end if
$0079	$3000			MOVLW	0
$007A	$0622			XORWF	_passo+1, 0
$007B	$1D03			BTFSS	STATUS, Z
$007C	$287F			GOTO	L_pulso_9
$007D	$3007			MOVLW	7
$007E	$0621			XORWF	_passo, 0
$007F	$	L_pulso_9:
$007F	$1D03			BTFSS	STATUS, Z
$0080	$2883			GOTO	ControleMotor5e6_L_38
$0081	$	ControleMotor5e6_L_37:
$0081	$3003			MOVLW	3
$0082	$0087			MOVWF	PORTC
$0083	$	ControleMotor5e6_L_38:
$0083	$	ControleMotor5e6_L_39:
;ControleMotor5e6.pbas,37 :: 		if passo=8 then PORTC=1 end if
$0083	$3000			MOVLW	0
$0084	$0622			XORWF	_passo+1, 0
$0085	$1D03			BTFSS	STATUS, Z
$0086	$2889			GOTO	L_pulso_10
$0087	$3008			MOVLW	8
$0088	$0621			XORWF	_passo, 0
$0089	$	L_pulso_10:
$0089	$1D03			BTFSS	STATUS, Z
$008A	$288D			GOTO	ControleMotor5e6_L_41
$008B	$	ControleMotor5e6_L_40:
$008B	$3001			MOVLW	1
$008C	$0087			MOVWF	PORTC
$008D	$	ControleMotor5e6_L_41:
$008D	$	ControleMotor5e6_L_42:
$008D	$	ControleMotor5e6_L_17:
;ControleMotor5e6.pbas,38 :: 		end if
$008D	$	ControleMotor5e6_L_18:
;ControleMotor5e6.pbas,40 :: 		if motor = 2 then
$008D	$3000			MOVLW	0
$008E	$0629			XORWF	FARG_pulso+1, 0
$008F	$1D03			BTFSS	STATUS, Z
$0090	$2893			GOTO	L_pulso_11
$0091	$3002			MOVLW	2
$0092	$0628			XORWF	FARG_pulso, 0
$0093	$	L_pulso_11:
$0093	$1D03			BTFSS	STATUS, Z
$0094	$28E5			GOTO	ControleMotor5e6_L_44
$0095	$	ControleMotor5e6_L_43:
;ControleMotor5e6.pbas,41 :: 		if passo=1 then PORTC=144 end if
$0095	$3000			MOVLW	0
$0096	$0622			XORWF	_passo+1, 0
$0097	$1D03			BTFSS	STATUS, Z
$0098	$289B			GOTO	L_pulso_12
$0099	$3001			MOVLW	1
$009A	$0621			XORWF	_passo, 0
$009B	$	L_pulso_12:
$009B	$1D03			BTFSS	STATUS, Z
$009C	$289F			GOTO	ControleMotor5e6_L_47
$009D	$	ControleMotor5e6_L_46:
$009D	$3090			MOVLW	144
$009E	$0087			MOVWF	PORTC
$009F	$	ControleMotor5e6_L_47:
$009F	$	ControleMotor5e6_L_48:
;ControleMotor5e6.pbas,42 :: 		if passo=2 then PORTC=128 end if
$009F	$3000			MOVLW	0
$00A0	$0622			XORWF	_passo+1, 0
$00A1	$1D03			BTFSS	STATUS, Z
$00A2	$28A5			GOTO	L_pulso_13
$00A3	$3002			MOVLW	2
$00A4	$0621			XORWF	_passo, 0
$00A5	$	L_pulso_13:
$00A5	$1D03			BTFSS	STATUS, Z
$00A6	$28A9			GOTO	ControleMotor5e6_L_50
$00A7	$	ControleMotor5e6_L_49:
$00A7	$3080			MOVLW	128
$00A8	$0087			MOVWF	PORTC
$00A9	$	ControleMotor5e6_L_50:
$00A9	$	ControleMotor5e6_L_51:
;ControleMotor5e6.pbas,43 :: 		if passo=3 then PORTC=192 end if
$00A9	$3000			MOVLW	0
$00AA	$0622			XORWF	_passo+1, 0
$00AB	$1D03			BTFSS	STATUS, Z
$00AC	$28AF			GOTO	L_pulso_14
$00AD	$3003			MOVLW	3
$00AE	$0621			XORWF	_passo, 0
$00AF	$	L_pulso_14:
$00AF	$1D03			BTFSS	STATUS, Z
$00B0	$28B3			GOTO	ControleMotor5e6_L_53
$00B1	$	ControleMotor5e6_L_52:
$00B1	$30C0			MOVLW	192
$00B2	$0087			MOVWF	PORTC
$00B3	$	ControleMotor5e6_L_53:
$00B3	$	ControleMotor5e6_L_54:
;ControleMotor5e6.pbas,44 :: 		if passo=4 then PORTC=64 end if
$00B3	$3000			MOVLW	0
$00B4	$0622			XORWF	_passo+1, 0
$00B5	$1D03			BTFSS	STATUS, Z
$00B6	$28B9			GOTO	L_pulso_15
$00B7	$3004			MOVLW	4
$00B8	$0621			XORWF	_passo, 0
$00B9	$	L_pulso_15:
$00B9	$1D03			BTFSS	STATUS, Z
$00BA	$28BD			GOTO	ControleMotor5e6_L_56
$00BB	$	ControleMotor5e6_L_55:
$00BB	$3040			MOVLW	64
$00BC	$0087			MOVWF	PORTC
$00BD	$	ControleMotor5e6_L_56:
$00BD	$	ControleMotor5e6_L_57:
;ControleMotor5e6.pbas,45 :: 		if passo=5 then PORTC=96 end if
$00BD	$3000			MOVLW	0
$00BE	$0622			XORWF	_passo+1, 0
$00BF	$1D03			BTFSS	STATUS, Z
$00C0	$28C3			GOTO	L_pulso_16
$00C1	$3005			MOVLW	5
$00C2	$0621			XORWF	_passo, 0
$00C3	$	L_pulso_16:
$00C3	$1D03			BTFSS	STATUS, Z
$00C4	$28C7			GOTO	ControleMotor5e6_L_59
$00C5	$	ControleMotor5e6_L_58:
$00C5	$3060			MOVLW	96
$00C6	$0087			MOVWF	PORTC
$00C7	$	ControleMotor5e6_L_59:
$00C7	$	ControleMotor5e6_L_60:
;ControleMotor5e6.pbas,46 :: 		if passo=6 then PORTC=32 end if
$00C7	$3000			MOVLW	0
$00C8	$0622			XORWF	_passo+1, 0
$00C9	$1D03			BTFSS	STATUS, Z
$00CA	$28CD			GOTO	L_pulso_17
$00CB	$3006			MOVLW	6
$00CC	$0621			XORWF	_passo, 0
$00CD	$	L_pulso_17:
$00CD	$1D03			BTFSS	STATUS, Z
$00CE	$28D1			GOTO	ControleMotor5e6_L_62
$00CF	$	ControleMotor5e6_L_61:
$00CF	$3020			MOVLW	32
$00D0	$0087			MOVWF	PORTC
$00D1	$	ControleMotor5e6_L_62:
$00D1	$	ControleMotor5e6_L_63:
;ControleMotor5e6.pbas,47 :: 		if passo=7 then PORTC=48 end if
$00D1	$3000			MOVLW	0
$00D2	$0622			XORWF	_passo+1, 0
$00D3	$1D03			BTFSS	STATUS, Z
$00D4	$28D7			GOTO	L_pulso_18
$00D5	$3007			MOVLW	7
$00D6	$0621			XORWF	_passo, 0
$00D7	$	L_pulso_18:
$00D7	$1D03			BTFSS	STATUS, Z
$00D8	$28DB			GOTO	ControleMotor5e6_L_65
$00D9	$	ControleMotor5e6_L_64:
$00D9	$3030			MOVLW	48
$00DA	$0087			MOVWF	PORTC
$00DB	$	ControleMotor5e6_L_65:
$00DB	$	ControleMotor5e6_L_66:
;ControleMotor5e6.pbas,48 :: 		if passo=8 then PORTC=16 end if
$00DB	$3000			MOVLW	0
$00DC	$0622			XORWF	_passo+1, 0
$00DD	$1D03			BTFSS	STATUS, Z
$00DE	$28E1			GOTO	L_pulso_19
$00DF	$3008			MOVLW	8
$00E0	$0621			XORWF	_passo, 0
$00E1	$	L_pulso_19:
$00E1	$1D03			BTFSS	STATUS, Z
$00E2	$28E5			GOTO	ControleMotor5e6_L_68
$00E3	$	ControleMotor5e6_L_67:
$00E3	$3010			MOVLW	16
$00E4	$0087			MOVWF	PORTC
$00E5	$	ControleMotor5e6_L_68:
$00E5	$	ControleMotor5e6_L_69:
$00E5	$	ControleMotor5e6_L_44:
;ControleMotor5e6.pbas,49 :: 		end if
$00E5	$	ControleMotor5e6_L_45:
$00E5	$2971			GOTO	ControleMotor5e6_L_3
;ControleMotor5e6.pbas,50 :: 		else
$00E6	$	ControleMotor5e6_L_2:
;ControleMotor5e6.pbas,51 :: 		if inverte = false then
$00E6	$082A			MOVF	FARG_pulso+2, 0
$00E7	$3A00			XORLW	0
$00E8	$1D03			BTFSS	STATUS, Z
$00E9	$28FB			GOTO	ControleMotor5e6_L_71
$00EA	$	ControleMotor5e6_L_70:
;ControleMotor5e6.pbas,52 :: 		inc(passo)
$00EA	$0AA1			INCF	_passo, 1
$00EB	$1903			BTFSC	STATUS, Z
$00EC	$0AA2			INCF	_passo+1, 1
;ControleMotor5e6.pbas,53 :: 		if passo > 4 then
$00ED	$3080			MOVLW	128
$00EE	$00F0			MOVWF	STACK_0
$00EF	$3080			MOVLW	128
$00F0	$0622			XORWF	_passo+1, 0
$00F1	$0270			SUBWF	STACK_0, 0
$00F2	$1D03			BTFSS	STATUS, Z
$00F3	$28F6			GOTO	L_pulso_20
$00F4	$0821			MOVF	_passo, 0
$00F5	$3C04			SUBLW	4
$00F6	$	L_pulso_20:
$00F6	$1803			BTFSC	STATUS, C
$00F7	$28FB			GOTO	ControleMotor5e6_L_74
$00F8	$	ControleMotor5e6_L_73:
;ControleMotor5e6.pbas,54 :: 		passo=1
$00F8	$3001			MOVLW	1
$00F9	$00A1			MOVWF	_passo
$00FA	$01A2			CLRF	_passo+1
$00FB	$	ControleMotor5e6_L_74:
;ControleMotor5e6.pbas,55 :: 		end if
$00FB	$	ControleMotor5e6_L_75:
$00FB	$	ControleMotor5e6_L_71:
;ControleMotor5e6.pbas,56 :: 		end if
$00FB	$	ControleMotor5e6_L_72:
;ControleMotor5e6.pbas,57 :: 		if inverte = true then
$00FB	$082A			MOVF	FARG_pulso+2, 0
$00FC	$3AFF			XORLW	255
$00FD	$1D03			BTFSS	STATUS, Z
$00FE	$2911			GOTO	ControleMotor5e6_L_77
$00FF	$	ControleMotor5e6_L_76:
;ControleMotor5e6.pbas,58 :: 		dec(passo)
$00FF	$3001			MOVLW	1
$0100	$02A1			SUBWF	_passo, 1
$0101	$1C03			BTFSS	STATUS, C
$0102	$03A2			DECF	_passo+1, 1
;ControleMotor5e6.pbas,59 :: 		if passo < 1 then
$0103	$3080			MOVLW	128
$0104	$0622			XORWF	_passo+1, 0
$0105	$00F0			MOVWF	STACK_0
$0106	$3080			MOVLW	128
$0107	$0270			SUBWF	STACK_0, 0
$0108	$1D03			BTFSS	STATUS, Z
$0109	$290C			GOTO	L_pulso_21
$010A	$3001			MOVLW	1
$010B	$0221			SUBWF	_passo, 0
$010C	$	L_pulso_21:
$010C	$1803			BTFSC	STATUS, C
$010D	$2911			GOTO	ControleMotor5e6_L_80
$010E	$	ControleMotor5e6_L_79:
;ControleMotor5e6.pbas,60 :: 		passo=4
$010E	$3004			MOVLW	4
$010F	$00A1			MOVWF	_passo
$0110	$01A2			CLRF	_passo+1
$0111	$	ControleMotor5e6_L_80:
;ControleMotor5e6.pbas,61 :: 		end if
$0111	$	ControleMotor5e6_L_81:
$0111	$	ControleMotor5e6_L_77:
;ControleMotor5e6.pbas,62 :: 		end if
$0111	$	ControleMotor5e6_L_78:
;ControleMotor5e6.pbas,64 :: 		if motor = 1 then
$0111	$3000			MOVLW	0
$0112	$0629			XORWF	FARG_pulso+1, 0
$0113	$1D03			BTFSS	STATUS, Z
$0114	$2917			GOTO	L_pulso_22
$0115	$3001			MOVLW	1
$0116	$0628			XORWF	FARG_pulso, 0
$0117	$	L_pulso_22:
$0117	$1D03			BTFSS	STATUS, Z
$0118	$2941			GOTO	ControleMotor5e6_L_83
$0119	$	ControleMotor5e6_L_82:
;ControleMotor5e6.pbas,65 :: 		if passo=1 then PORTC=8 end if
$0119	$3000			MOVLW	0
$011A	$0622			XORWF	_passo+1, 0
$011B	$1D03			BTFSS	STATUS, Z
$011C	$291F			GOTO	L_pulso_23
$011D	$3001			MOVLW	1
$011E	$0621			XORWF	_passo, 0
$011F	$	L_pulso_23:
$011F	$1D03			BTFSS	STATUS, Z
$0120	$2923			GOTO	ControleMotor5e6_L_86
$0121	$	ControleMotor5e6_L_85:
$0121	$3008			MOVLW	8
$0122	$0087			MOVWF	PORTC
$0123	$	ControleMotor5e6_L_86:
$0123	$	ControleMotor5e6_L_87:
;ControleMotor5e6.pbas,66 :: 		if passo=2 then PORTC=4 end if
$0123	$3000			MOVLW	0
$0124	$0622			XORWF	_passo+1, 0
$0125	$1D03			BTFSS	STATUS, Z
$0126	$2929			GOTO	L_pulso_24
$0127	$3002			MOVLW	2
$0128	$0621			XORWF	_passo, 0
$0129	$	L_pulso_24:
$0129	$1D03			BTFSS	STATUS, Z
$012A	$292D			GOTO	ControleMotor5e6_L_89
$012B	$	ControleMotor5e6_L_88:
$012B	$3004			MOVLW	4
$012C	$0087			MOVWF	PORTC
$012D	$	ControleMotor5e6_L_89:
$012D	$	ControleMotor5e6_L_90:
;ControleMotor5e6.pbas,67 :: 		if passo=3 then PORTC=2 end if
$012D	$3000			MOVLW	0
$012E	$0622			XORWF	_passo+1, 0
$012F	$1D03			BTFSS	STATUS, Z
$0130	$2933			GOTO	L_pulso_25
$0131	$3003			MOVLW	3
$0132	$0621			XORWF	_passo, 0
$0133	$	L_pulso_25:
$0133	$1D03			BTFSS	STATUS, Z
$0134	$2937			GOTO	ControleMotor5e6_L_92
$0135	$	ControleMotor5e6_L_91:
$0135	$3002			MOVLW	2
$0136	$0087			MOVWF	PORTC
$0137	$	ControleMotor5e6_L_92:
$0137	$	ControleMotor5e6_L_93:
;ControleMotor5e6.pbas,68 :: 		if passo=4 then PORTC=1 end if
$0137	$3000			MOVLW	0
$0138	$0622			XORWF	_passo+1, 0
$0139	$1D03			BTFSS	STATUS, Z
$013A	$293D			GOTO	L_pulso_26
$013B	$3004			MOVLW	4
$013C	$0621			XORWF	_passo, 0
$013D	$	L_pulso_26:
$013D	$1D03			BTFSS	STATUS, Z
$013E	$2941			GOTO	ControleMotor5e6_L_95
$013F	$	ControleMotor5e6_L_94:
$013F	$3001			MOVLW	1
$0140	$0087			MOVWF	PORTC
$0141	$	ControleMotor5e6_L_95:
$0141	$	ControleMotor5e6_L_96:
$0141	$	ControleMotor5e6_L_83:
;ControleMotor5e6.pbas,69 :: 		end if
$0141	$	ControleMotor5e6_L_84:
;ControleMotor5e6.pbas,71 :: 		if motor = 2 then
$0141	$3000			MOVLW	0
$0142	$0629			XORWF	FARG_pulso+1, 0
$0143	$1D03			BTFSS	STATUS, Z
$0144	$2947			GOTO	L_pulso_27
$0145	$3002			MOVLW	2
$0146	$0628			XORWF	FARG_pulso, 0
$0147	$	L_pulso_27:
$0147	$1D03			BTFSS	STATUS, Z
$0148	$2971			GOTO	ControleMotor5e6_L_98
$0149	$	ControleMotor5e6_L_97:
;ControleMotor5e6.pbas,72 :: 		if passo=1 then PORTC=128 end if
$0149	$3000			MOVLW	0
$014A	$0622			XORWF	_passo+1, 0
$014B	$1D03			BTFSS	STATUS, Z
$014C	$294F			GOTO	L_pulso_28
$014D	$3001			MOVLW	1
$014E	$0621			XORWF	_passo, 0
$014F	$	L_pulso_28:
$014F	$1D03			BTFSS	STATUS, Z
$0150	$2953			GOTO	ControleMotor5e6_L_101
$0151	$	ControleMotor5e6_L_100:
$0151	$3080			MOVLW	128
$0152	$0087			MOVWF	PORTC
$0153	$	ControleMotor5e6_L_101:
$0153	$	ControleMotor5e6_L_102:
;ControleMotor5e6.pbas,73 :: 		if passo=2 then PORTC=64  end if
$0153	$3000			MOVLW	0
$0154	$0622			XORWF	_passo+1, 0
$0155	$1D03			BTFSS	STATUS, Z
$0156	$2959			GOTO	L_pulso_29
$0157	$3002			MOVLW	2
$0158	$0621			XORWF	_passo, 0
$0159	$	L_pulso_29:
$0159	$1D03			BTFSS	STATUS, Z
$015A	$295D			GOTO	ControleMotor5e6_L_104
$015B	$	ControleMotor5e6_L_103:
$015B	$3040			MOVLW	64
$015C	$0087			MOVWF	PORTC
$015D	$	ControleMotor5e6_L_104:
$015D	$	ControleMotor5e6_L_105:
;ControleMotor5e6.pbas,74 :: 		if passo=3 then PORTC=32  end if
$015D	$3000			MOVLW	0
$015E	$0622			XORWF	_passo+1, 0
$015F	$1D03			BTFSS	STATUS, Z
$0160	$2963			GOTO	L_pulso_30
$0161	$3003			MOVLW	3
$0162	$0621			XORWF	_passo, 0
$0163	$	L_pulso_30:
$0163	$1D03			BTFSS	STATUS, Z
$0164	$2967			GOTO	ControleMotor5e6_L_107
$0165	$	ControleMotor5e6_L_106:
$0165	$3020			MOVLW	32
$0166	$0087			MOVWF	PORTC
$0167	$	ControleMotor5e6_L_107:
$0167	$	ControleMotor5e6_L_108:
;ControleMotor5e6.pbas,75 :: 		if passo=4 then PORTC=16  end if
$0167	$3000			MOVLW	0
$0168	$0622			XORWF	_passo+1, 0
$0169	$1D03			BTFSS	STATUS, Z
$016A	$296D			GOTO	L_pulso_31
$016B	$3004			MOVLW	4
$016C	$0621			XORWF	_passo, 0
$016D	$	L_pulso_31:
$016D	$1D03			BTFSS	STATUS, Z
$016E	$2971			GOTO	ControleMotor5e6_L_110
$016F	$	ControleMotor5e6_L_109:
$016F	$3010			MOVLW	16
$0170	$0087			MOVWF	PORTC
$0171	$	ControleMotor5e6_L_110:
$0171	$	ControleMotor5e6_L_111:
$0171	$	ControleMotor5e6_L_98:
;ControleMotor5e6.pbas,76 :: 		end if
$0171	$	ControleMotor5e6_L_99:
;ControleMotor5e6.pbas,78 :: 		end if
$0171	$	ControleMotor5e6_L_3:
$0171	$	ControleMotor5e6_L_0:
$0171	$0008			RETURN
$0172	$	_main:
;ControleMotor5e6.pbas,81 :: 		main:
$0172	$	_main_main:
;ControleMotor5e6.pbas,82 :: 		TRISA=%11111111
$0172	$30FF			MOVLW	255
$0173	$1303			BCF	STATUS, RP1
$0174	$1683			BSF	STATUS, RP0
$0175	$0085			MOVWF	TRISA
;ControleMotor5e6.pbas,83 :: 		TRISB=%01111111
$0176	$307F			MOVLW	127
$0177	$0086			MOVWF	TRISB
;ControleMotor5e6.pbas,84 :: 		TRISC=%00000000
$0178	$0187			CLRF	TRISC, 1
;ControleMotor5e6.pbas,85 :: 		INTCON=%00000000
$0179	$018B			CLRF	INTCON, 1
;ControleMotor5e6.pbas,86 :: 		ANSEL=%00000000
$017A	$1703			BSF	STATUS, RP1
$017B	$1283			BCF	STATUS, RP0
$017C	$019E			CLRF	ANSEL, 1
;ControleMotor5e6.pbas,87 :: 		ANSELH=%00000000
$017D	$019F			CLRF	ANSELH, 1
;ControleMotor5e6.pbas,89 :: 		PORTC=0
$017E	$1303			BCF	STATUS, RP1
$017F	$0187			CLRF	PORTC, 1
;ControleMotor5e6.pbas,91 :: 		passo=0
$0180	$01A1			CLRF	_passo
$0181	$01A2			CLRF	_passo+1
;ControleMotor5e6.pbas,92 :: 		borda=false
$0182	$01A3			CLRF	_borda, 1
;ControleMotor5e6.pbas,93 :: 		borda2=false
$0183	$01A4			CLRF	_borda2, 1
;ControleMotor5e6.pbas,94 :: 		borda3=false
$0184	$01A5			CLRF	_borda3, 1
;ControleMotor5e6.pbas,95 :: 		borda4=false
$0185	$01A6			CLRF	_borda4, 1
;ControleMotor5e6.pbas,96 :: 		dirAntHor=false
$0186	$01A7			CLRF	_diranthor, 1
;ControleMotor5e6.pbas,97 :: 		revolucao=true 'true 400 pulsos por revolu��o
$0187	$30FF			MOVLW	255
$0188	$00A0			MOVWF	_revolucao
;ControleMotor5e6.pbas,100 :: 		executa:
$0189	$	_main_executa:
;ControleMotor5e6.pbas,102 :: 		if testbit(porta,0)=1 then
$0189	$3001			MOVLW	1
$018A	$0505			ANDWF	PORTA, 0
$018B	$00F1			MOVWF	STACK_1
$018C	$0871			MOVF	STACK_1, 0
$018D	$3A01			XORLW	1
$018E	$1D03			BTFSS	STATUS, Z
$018F	$299C			GOTO	ControleMotor5e6_L_114
$0190	$	ControleMotor5e6_L_113:
;ControleMotor5e6.pbas,103 :: 		if borda=false then
$0190	$0823			MOVF	_borda, 0
$0191	$3A00			XORLW	0
$0192	$1D03			BTFSS	STATUS, Z
$0193	$299C			GOTO	ControleMotor5e6_L_117
$0194	$	ControleMotor5e6_L_116:
;ControleMotor5e6.pbas,104 :: 		borda=true
$0194	$30FF			MOVLW	255
$0195	$00A3			MOVWF	_borda
;ControleMotor5e6.pbas,105 :: 		pulso(1, dirAntHor)
$0196	$3001			MOVLW	1
$0197	$00A8			MOVWF	FARG_pulso
$0198	$01A9			CLRF	FARG_pulso+1
$0199	$0827			MOVF	_diranthor, 0
$019A	$00AA			MOVWF	FARG_pulso+2
$019B	$2004			CALL	_pulso
$019C	$	ControleMotor5e6_L_117:
;ControleMotor5e6.pbas,106 :: 		end if
$019C	$	ControleMotor5e6_L_118:
$019C	$	ControleMotor5e6_L_114:
;ControleMotor5e6.pbas,107 :: 		end if
$019C	$	ControleMotor5e6_L_115:
;ControleMotor5e6.pbas,108 :: 		if testbit(porta,0)=0 then
$019C	$3001			MOVLW	1
$019D	$0505			ANDWF	PORTA, 0
$019E	$00F1			MOVWF	STACK_1
$019F	$0871			MOVF	STACK_1, 0
$01A0	$3A00			XORLW	0
$01A1	$1D03			BTFSS	STATUS, Z
$01A2	$29A4			GOTO	ControleMotor5e6_L_120
$01A3	$	ControleMotor5e6_L_119:
;ControleMotor5e6.pbas,109 :: 		borda=false
$01A3	$01A3			CLRF	_borda, 1
$01A4	$	ControleMotor5e6_L_120:
;ControleMotor5e6.pbas,110 :: 		end if
$01A4	$	ControleMotor5e6_L_121:
;ControleMotor5e6.pbas,113 :: 		if testbit(porta,1)=1 then
$01A4	$3000			MOVLW	0
$01A5	$1885			BTFSC	PORTA, 1
$01A6	$3001			MOVLW	1
$01A7	$00F1			MOVWF	STACK_1
$01A8	$0871			MOVF	STACK_1, 0
$01A9	$3A01			XORLW	1
$01AA	$1D03			BTFSS	STATUS, Z
$01AB	$29B8			GOTO	ControleMotor5e6_L_123
$01AC	$	ControleMotor5e6_L_122:
;ControleMotor5e6.pbas,114 :: 		if borda2=false then
$01AC	$0824			MOVF	_borda2, 0
$01AD	$3A00			XORLW	0
$01AE	$1D03			BTFSS	STATUS, Z
$01AF	$29B8			GOTO	ControleMotor5e6_L_126
$01B0	$	ControleMotor5e6_L_125:
;ControleMotor5e6.pbas,115 :: 		borda2=true
$01B0	$30FF			MOVLW	255
$01B1	$00A4			MOVWF	_borda2
;ControleMotor5e6.pbas,116 :: 		pulso(2, dirAntHor)
$01B2	$3002			MOVLW	2
$01B3	$00A8			MOVWF	FARG_pulso
$01B4	$01A9			CLRF	FARG_pulso+1
$01B5	$0827			MOVF	_diranthor, 0
$01B6	$00AA			MOVWF	FARG_pulso+2
$01B7	$2004			CALL	_pulso
$01B8	$	ControleMotor5e6_L_126:
;ControleMotor5e6.pbas,117 :: 		end if
$01B8	$	ControleMotor5e6_L_127:
$01B8	$	ControleMotor5e6_L_123:
;ControleMotor5e6.pbas,118 :: 		end if
$01B8	$	ControleMotor5e6_L_124:
;ControleMotor5e6.pbas,119 :: 		if testbit(porta,1)=0 then
$01B8	$3000			MOVLW	0
$01B9	$1885			BTFSC	PORTA, 1
$01BA	$3001			MOVLW	1
$01BB	$00F1			MOVWF	STACK_1
$01BC	$0871			MOVF	STACK_1, 0
$01BD	$3A00			XORLW	0
$01BE	$1D03			BTFSS	STATUS, Z
$01BF	$29C1			GOTO	ControleMotor5e6_L_129
$01C0	$	ControleMotor5e6_L_128:
;ControleMotor5e6.pbas,120 :: 		borda2=false
$01C0	$01A4			CLRF	_borda2, 1
$01C1	$	ControleMotor5e6_L_129:
;ControleMotor5e6.pbas,121 :: 		end if
$01C1	$	ControleMotor5e6_L_130:
;ControleMotor5e6.pbas,124 :: 		if testbit(porta,2)=1 then
$01C1	$3000			MOVLW	0
$01C2	$1905			BTFSC	PORTA, 2
$01C3	$3001			MOVLW	1
$01C4	$00F1			MOVWF	STACK_1
$01C5	$0871			MOVF	STACK_1, 0
$01C6	$3A01			XORLW	1
$01C7	$1D03			BTFSS	STATUS, Z
$01C8	$29CC			GOTO	ControleMotor5e6_L_132
$01C9	$	ControleMotor5e6_L_131:
;ControleMotor5e6.pbas,125 :: 		dirAntHor = true
$01C9	$30FF			MOVLW	255
$01CA	$00A7			MOVWF	_diranthor
$01CB	$29CD			GOTO	ControleMotor5e6_L_133
;ControleMotor5e6.pbas,126 :: 		else
$01CC	$	ControleMotor5e6_L_132:
;ControleMotor5e6.pbas,127 :: 		dirAntHor = false
$01CC	$01A7			CLRF	_diranthor, 1
;ControleMotor5e6.pbas,128 :: 		end if
$01CD	$	ControleMotor5e6_L_133:
;ControleMotor5e6.pbas,131 :: 		if testbit(porta,3)=1 then
$01CD	$3000			MOVLW	0
$01CE	$1985			BTFSC	PORTA, 3
$01CF	$3001			MOVLW	1
$01D0	$00F1			MOVWF	STACK_1
$01D1	$0871			MOVF	STACK_1, 0
$01D2	$3A01			XORLW	1
$01D3	$1D03			BTFSS	STATUS, Z
$01D4	$29F1			GOTO	ControleMotor5e6_L_135
$01D5	$	ControleMotor5e6_L_134:
;ControleMotor5e6.pbas,132 :: 		if borda4=false then
$01D5	$0826			MOVF	_borda4, 0
$01D6	$3A00			XORLW	0
$01D7	$1D03			BTFSS	STATUS, Z
$01D8	$29F1			GOTO	ControleMotor5e6_L_138
$01D9	$	ControleMotor5e6_L_137:
;ControleMotor5e6.pbas,133 :: 		borda4=true
$01D9	$30FF			MOVLW	255
$01DA	$00A6			MOVWF	_borda4
;ControleMotor5e6.pbas,134 :: 		if revolucao=false then
$01DB	$0820			MOVF	_revolucao, 0
$01DC	$3A00			XORLW	0
$01DD	$1D03			BTFSS	STATUS, Z
$01DE	$29E2			GOTO	ControleMotor5e6_L_141
$01DF	$	ControleMotor5e6_L_140:
;ControleMotor5e6.pbas,135 :: 		revolucao = true
$01DF	$30FF			MOVLW	255
$01E0	$00A0			MOVWF	_revolucao
$01E1	$29F1			GOTO	ControleMotor5e6_L_142
;ControleMotor5e6.pbas,136 :: 		else
$01E2	$	ControleMotor5e6_L_141:
;ControleMotor5e6.pbas,137 :: 		revolucao=false
$01E2	$01A0			CLRF	_revolucao, 1
;ControleMotor5e6.pbas,138 :: 		if passo > 4 then
$01E3	$3080			MOVLW	128
$01E4	$00F0			MOVWF	STACK_0
$01E5	$3080			MOVLW	128
$01E6	$0622			XORWF	_passo+1, 0
$01E7	$0270			SUBWF	STACK_0, 0
$01E8	$1D03			BTFSS	STATUS, Z
$01E9	$29EC			GOTO	L_main_32
$01EA	$0821			MOVF	_passo, 0
$01EB	$3C04			SUBLW	4
$01EC	$	L_main_32:
$01EC	$1803			BTFSC	STATUS, C
$01ED	$29F1			GOTO	ControleMotor5e6_L_144
$01EE	$	ControleMotor5e6_L_143:
;ControleMotor5e6.pbas,139 :: 		passo=4
$01EE	$3004			MOVLW	4
$01EF	$00A1			MOVWF	_passo
$01F0	$01A2			CLRF	_passo+1
$01F1	$	ControleMotor5e6_L_144:
;ControleMotor5e6.pbas,140 :: 		end if
$01F1	$	ControleMotor5e6_L_145:
;ControleMotor5e6.pbas,141 :: 		end if
$01F1	$	ControleMotor5e6_L_142:
$01F1	$	ControleMotor5e6_L_138:
;ControleMotor5e6.pbas,142 :: 		end if
$01F1	$	ControleMotor5e6_L_139:
$01F1	$	ControleMotor5e6_L_135:
;ControleMotor5e6.pbas,143 :: 		end if
$01F1	$	ControleMotor5e6_L_136:
;ControleMotor5e6.pbas,144 :: 		if testbit(porta,3)=0 then
$01F1	$3000			MOVLW	0
$01F2	$1985			BTFSC	PORTA, 3
$01F3	$3001			MOVLW	1
$01F4	$00F1			MOVWF	STACK_1
$01F5	$0871			MOVF	STACK_1, 0
$01F6	$3A00			XORLW	0
$01F7	$1D03			BTFSS	STATUS, Z
$01F8	$29FA			GOTO	ControleMotor5e6_L_147
$01F9	$	ControleMotor5e6_L_146:
;ControleMotor5e6.pbas,145 :: 		borda4=false
$01F9	$01A6			CLRF	_borda4, 1
$01FA	$	ControleMotor5e6_L_147:
;ControleMotor5e6.pbas,146 :: 		end if
$01FA	$	ControleMotor5e6_L_148:
;ControleMotor5e6.pbas,148 :: 		goto executa
$01FA	$2989			GOTO	_main_executa
$01FB	$29FB			GOTO	$
