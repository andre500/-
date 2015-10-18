{$CLEO}
{$NOSOURCE}
{$INCLUDE Values.TXT}
{$INCLUDE LocalOpcodes.TXT}
0000:
{Чудаки и незнакомцы - by andre500}
thread 'ANDRE'
var
1@: int = 0
387@: int = 0
386@: int = 0
end

:SAMP
wait 0
0AA2: 0@ = load_library "Kernel32.dll" // IF and SET
else_jump @SAMP
0AA4: 1@ = get_proc_address "GetModuleHandleA" library 0@ // IF and SET
0AA7: call_function 1@ num_params 1 pop 0 "samp.dll" handle_to 2@
0AA3: free_library 0@
2@ > 0                                      
else_jump @loading
0A93: end_custom_thread

:loading
0AB1: call_scm_func @value_hack_1 2 1 1@ 
0AB1: call_scm_func @value_hack_2 1 1 6@
03E5: show_text_box 'LOADED'  // 'Чудаки и незнакомцы' by andre500 успешно загружен!/nUpdate от 29.06.15
0B00: delete_file "data\Paths\InfoUPDATE"  // IF and SET
wait 5000

:SETTINGS
wait 0
0AF0: 10@ = get_int_from_ini_file "cleo\Settings.ini" section "UPDATE" key "VALUE"
10@ == 1
else_jump @random
0A92: create_custom_thread "StartUPDATE.s"
0662: printstring "StartUPDATE.s"

:NEXT
0AF0: 10@ = get_int_from_ini_file "data\Paths\Path402.dat" section "OFF" key "NEXT"
wait 0
10@ == 1
else_jump @NEXT
0ABA: end_custom_thread_named 'UPD'
13@ = 0
0AF1: write_int 13@ to_ini_file "data\Paths\Path402.dat" section "OFF" key "NEXT"
jump @random

:random
0209: 2@ = random_int_in_ranges 1 10
0663: printint "random" 2@

:PLAYER
wait 0
Player.Defined($PLAYER_CHAR)
else_jump @PLAYER
09E8: 0@ = actor $PLAYER_ACTOR active_interior
0663: printint "INT_TEST" 0@
0@ == 0
else_jump @PLAYER
0842: 18@ = player $PLAYER_CHAR town_number 
0663: printint "town_number_TEST" 18@

:town_numberLS
wait 0
18@ == 1
else_jump @town_numberSF
0662: printstring "RAND_N1 BLOCK Sucsess Start!"
jump @RAND_N1

:town_numberSF
18@ == 2
else_jump @town_numberLV
0662: printstring "RAND_N11 BLOCK Sucsess Start!"
jump @RAND_N11

:town_numberLV
18@ == 3
else_jump @town_numberLS
0662: printstring "RAND_N12 BLOCK Sucsess Start!"
jump @RAND_N21
//********************************************************************************//

:RAND_N1
wait 0
2@ == 1
else_jump @RAND_N2
0662: printstring "BLOCK 1 N1 STARTED"
jump @Z_N1

:RAND_N2
2@ == 2
else_jump @RAND_N3
0662: printstring "BLOCK 1 N2 STARTED"
jump @Z_N2

:RAND_N3
2@ == 3
else_jump @RAND_N4
0662: printstring "BLOCK 1 N3 STARTED"
jump @Z_N3

:RAND_N4
2@ == 4
else_jump @RAND_N5
0662: printstring "BLOCK 1 N4 STARTED"
jump @Z_N4

:RAND_N5
2@ == 5
else_jump @RAND_N6
0662: printstring "BLOCK 1 N5 STARTED"
jump @Z_N5

:RAND_N6
2@ == 6
else_jump @RAND_N7
0662: printstring "BLOCK 1 N6 STARTED"
jump @Z_N6

:RAND_N7
2@ == 7
else_jump @RAND_N8
0662: printstring "BLOCK 1 N7 STARTED"
jump @Z_N7

:RAND_N8
2@ == 8
else_jump @RAND_N9
0662: printstring "BLOCK 1 N8 STARTED"
jump @Z_N8

:RAND_N9
2@ == 9
else_jump @RAND_N10
0662: printstring "BLOCK 1 N9 STARTED"
jump @Z_N9

:RAND_N10
2@ == 10
else_jump @PLAYER
0662: printstring "BLOCK 1 N10 STARTED"
jump @Z_N10

:RAND_N11
wait 0
2@ == 1
else_jump @RAND_N12
0662: printstring "BLOCK 2 N1 STARTED"
jump @Z_N11

:RAND_N12
2@ == 2
else_jump @RAND_N13
0662: printstring "BLOCK 2 N2 STARTED"
jump @Z_N12

:RAND_N13
2@ == 3
else_jump @RAND_N14
0662: printstring "BLOCK 2 N3 STARTED"
jump @Z_N13

:RAND_N14
2@ == 4
else_jump @RAND_N15
0662: printstring "BLOCK 2 N4 STARTED"
jump @Z_N14

:RAND_N15
2@ == 5
else_jump @RAND_N16
0662: printstring "BLOCK 2 N5 STARTED"
jump @Z_N15

:RAND_N16
2@ == 6
else_jump @RAND_N17
0662: printstring "BLOCK 2 N6 STARTED"
jump @Z_N16

:RAND_N17
2@ == 7
else_jump @RAND_N18
0662: printstring "BLOCK 2 N7 STARTED"
jump @Z_N17

:RAND_N18
2@ == 8
else_jump @RAND_N19
0662: printstring "BLOCK 2 N8 STARTED"
jump @Z_N18

:RAND_N19
2@ == 9
else_jump @RAND_N20
0662: printstring "BLOCK 2 N9 STARTED"
jump @Z_N19

:RAND_N20
2@ == 10
else_jump @PLAYER
0662: printstring "BLOCK 2 N10 STARTED"
jump @Z_N20

:RAND_N21
wait 0
2@ == 1
else_jump @RAND_N22
0662: printstring "BLOCK 3 N1 STARTED"
jump @Z_N21

:RAND_N22
2@ == 2
else_jump @RAND_N23
0662: printstring "BLOCK 3 N2 STARTED"
jump @Z_N22

:RAND_N23
2@ == 3
else_jump @RAND_N24
0662: printstring "BLOCK 3 N3 STARTED"
jump @Z_N23

:RAND_N24
2@ == 4
else_jump @RAND_N25
0662: printstring "BLOCK 3 N4 STARTED"
jump @Z_N24

:RAND_N25
2@ == 5
else_jump @RAND_N26
0662: printstring "BLOCK 3 N5 STARTED"
jump @Z_N25

:RAND_N26
2@ == 6
else_jump @RAND_N27
0662: printstring "BLOCK 3 N6 STARTED"
jump @Z_N26

:RAND_N27
2@ == 7
else_jump @RAND_N28
0662: printstring "BLOCK 3 N7 STARTED"
jump @Z_N27

:RAND_N28
2@ == 8
else_jump @RAND_N29
0662: printstring "BLOCK 3 N8 STARTED"
jump @Z_N28

:RAND_N29
2@ == 9
else_jump @RAND_N30
0662: printstring "BLOCK 3 N9 STARTED"
jump @Z_N29

:RAND_N30
2@ == 10
else_jump @PLAYER
0662: printstring "BLOCK 3 N10 STARTED"
jump @Z_N30

//********************************************************************************//

:Z_N1
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N1
056D:   actor 1@ defined
else_jump @Z_N1
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N1
03A3:   actor 1@ male
else_jump @Z_N1
not Actor.Driving(1@)
else_jump @Z_N1
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N1
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N1
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N1
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N1
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N1
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N1
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N1
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N1
$ONMISSION == 0 
else_jump @Z_N1
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN1
wait 0
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @run_to_actorN1_NO
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
05C1: AS_actor 1@ speak_from_audio_table 166
00BC: show_text_highpriority GXT 'CHDN1' time 5000 flag 1  //Чувак, мне нужно угнать автомобиль для участия в гонках лоурайдеров. Не поможешь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y1
wait 0
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N1
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
05C1: AS_actor 1@ speak_from_audio_table 168
00BC: show_text_highpriority GXT 'CHDZ1' time 5000 flag 1  //Найди и угони любой лоурайдерский автомобиль.
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"
Actor.RemoveReferences(1@)

:LCAR
wait 0
Actor.Driving($PLAYER_ACTOR)
else_jump @LCAR
7@ = Actor.CurrentCar($PLAYER_ACTOR)
096E:   car 7@ lowrider
else_jump @LCAR
00BC: show_text_highpriority GXT 'CHDE1' time 5000 flag 1  //Отвези автомобиль в гараж заказчика
018A: 8@ = create_checkpoint_at 2347.4153 -1218.7439 22.5
08FB: set_checkpoint 8@ type_to 0

:END_Z1
wait 0
0101:   actor $PLAYER_ACTOR in_sphere 2347.4153 -1218.7439 22.5 radius 1.5 1.5 10.5 sphere 1.5 stopped 
else_jump @END_Z1
Actor.InCar($PLAYER_ACTOR, 7@)
else_jump @END_Z1_F
0633: AS_actor $PLAYER_ACTOR exit_car
0394: play_music 2
17@ = 3000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
0632: release_group $PLAYER_GROUP
Car.RemoveReferences(7@)
Marker.Disable(8@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 903@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
wait 8000
0513: show_text_box_1number 'ERRT' number 2@ 
jump @TIMER

:END_Z1_F
if or
gosub @WASTED_OR_BUSTED
Car.Wrecked(7@)
else_jump @END_Z1
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
0632: release_group $PLAYER_GROUP
Car.RemoveReferences(7@)
Marker.Disable(8@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 903@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N1
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y1
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1 // Вы отказались от поручения!
$ONMISSION = 0
05DE: AS_actor 1@ walk_around_ped_path
Marker.Disable(27@)
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorN1_NO
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN1
Marker.Disable(27@)
jump @random

:Z_N2
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N2
056D:   actor 1@ defined
else_jump @Z_N2
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N2
03A3:   actor 1@ male
else_jump @Z_N2
not Actor.Driving(1@)
else_jump @Z_N2
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N2
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N2
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N2
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N2
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N2
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N2
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N2
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N2
$ONMISSION == 0 
else_jump @Z_N2
Marker.CreateAboveActor(27@,1@)

:run_to_actorN2
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO2
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN2' time 5000 flag 1  //Эй, парень, мне нужно убить одного человека, он слишком много знает.
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y2
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N2
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CHDZ2' time 5000 flag 1  //Отправляйся к зданию суда и убей свидетеля.
018A: 8@ = create_checkpoint_at 1245.3645 -1562.0354 13.555
08FB: set_checkpoint 8@ type_to 0
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
Model.Load(#WMYRI)
Model.Load(#CELLPHONE)
038B: load_requested_models
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:CACT
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 1306.2094 -1564.3351 13.5391 radius 100.0 100.0 100.0
else_jump @CACT
Marker.Disable(8@)
12@ = Actor.Create(CivMale, #WMYRI, 1245.3645, -1562.0354, 13.555)
Actor.Angle(12@) = 236.7121
0729: AS_actor 12@ hold_cellphone 1
Marker.CreateAboveActor(13@, 12@)
00BC: show_text_highpriority GXT 'CHDE2' time 5000 flag 1  //Убей свидетеля и скройся с места преступления.

:BEG_GUN
wait 0
00F2:   actor $PLAYER_ACTOR near_actor 12@ radius 6.0 6.0 sphere 0
else_jump @END_CACT
0470: 76@ = actor $PLAYER_ACTOR current_weapon
if or
76@ == 0
76@ == 1
76@ == 2
76@ == 3
76@ == 6
76@ == 7
else_jump @FAIL_COPS
if or
76@ == 40
76@ == 41
76@ == 41
76@ == 42
76@ == 43
76@ == 44
76@ == 45
76@ == 46
else_jump @FAIL_COPS
jump @END_CACT

:FAIL_COPS
0729: AS_actor 12@ hold_cellphone 0
00BC: show_text_highpriority GXT 'CHEE2' time 5000 flag 1  //Помогите, у этого человека в руках оружие!
05DA: AS_actor 12@ run_away_in_panic_from 882.0281 -1564.6775 13.5391 away_radius 100.0 timelimit 999999

:COP_FIND
Actor.StorePos(12@, 78@, 79@, 80@)
0AE1: 77@ = random_actor_near_point 78@ 79@ 80@ in_radius 15.0 find_next 1 pass_deads 1
056D:   actor 77@ defined
else_jump @GUN_DIE
089F: get_actor 77@ pedtype_to 81@
81@ == 6
else_jump @GUN_DIE
010D: set_player $PLAYER_CHAR wanted_level_to 2
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
00BC: show_text_highpriority GXT 'CHEF2' time 5000 flag 1 //Вас заметили полицейские!
$ONMISSION = 0
Marker.Disable(13@)
Model.Destroy(#WMYRI)
Model.Destroy(#CELLPHONE)
wait 5000
Actor.RemoveReferences(12@)
903@ = 0
0AF0: 903@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:END_CACT
Actor.Dead(12@)
else_jump @BEG_GUN
Marker.Disable(13@)
Actor.RemoveReferences(12@)
Model.Destroy(#WMYRI)
Model.Destroy(#CELLPHONE)
010D: set_player $PLAYER_CHAR wanted_level_to 2
0394: play_music 2
17@ = 5000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
903@ = 0
0AF0: 903@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:GUN_DIE
wait 0
Actor.Dead(12@)
else_jump @GUN_DIE
Marker.Disable(13@)
Actor.RemoveReferences(12@)
Model.Destroy(#WMYRI)
Model.Destroy(#CELLPHONE)
010D: set_player $PLAYER_CHAR wanted_level_to 2
0394: play_music 2
17@ = 5000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 903@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:KEY_N2
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y2
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO2
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN2
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random 

:Z_N3
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N3
056D:   actor 1@ defined
else_jump @Z_N3
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N3
03A3:   actor 1@ male
else_jump @Z_N3
not Actor.Driving(1@)
else_jump @Z_N3
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N3
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N3
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N3
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N3
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N3
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N3
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N3
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N3
$ONMISSION == 0 
else_jump @Z_N3
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN3
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO3
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN3' time 5000 flag 1  //Хочу насолить своему знакомому. Не поможешь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y3
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N3
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
018A: 8@ = create_checkpoint_at 339.8804 -1348.5762 14.5078
08FB: set_checkpoint 8@ type_to 0
00BC: show_text_highpriority GXT 'CHDZ3' time 5000 flag 1  //Отправляйся на автомобильную стоянку.
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
Model.Load(#SUPERGT)
038B: load_requested_models
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:CAR_PARK
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 541.6914 -1255.0541 16.5647 radius 100.0 100.0 100.0
else_jump @CAR_PARK
Model.Available(#SUPERGT)
else_jump @FAIL_M
Marker.Disable(8@)
14@ = Car.Create(#SUPERGT, 339.8804, -1348.5762, 14.5078)
Car.Angle(14@) = 301.2508
Marker.CreateAboveCar(15@, 14@)
Car.DoorStatus(14@) = 4
00BC: show_text_highpriority GXT 'CHDE3' time 5000 flag 1  //Проколи все шины у автомобиля с помощью огнестрельного оружия.

:END_CAR_PACK
wait 0
if and
0496:   tire 0 on_car 14@ deflated
0496:   tire 1 on_car 14@ deflated
0496:   tire 2 on_car 14@ deflated
0496:   tire 3 on_car 14@ deflated
else_jump @END_CAR_PACK_FAIL
Marker.Disable(15@)
Car.RemoveReferences(14@)
Model.Destroy(#SUPERGT)
0394: play_music 2
17@ = 2000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 903@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:END_CAR_PACK_FAIL
if or
gosub @WASTED_OR_BUSTED
Car.Wrecked(14@)
else_jump @END_CAR_PACK
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
00BC: show_text_highpriority GXT 'CHEF3' time 5000 flag 1 //В поручении было сказано 'проколоть шины', а не 'взорвать автомобиль'!
$ONMISSION = 0
Marker.Disable(15@)                                                                                                              
Car.RemoveReferences(14@)
Model.Destroy(#SUPERGT)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 903@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N3
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y3
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO3
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN3
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:FAIL_M
Model.Load(#SUPERGT)
038B: load_requested_models
jump @CAR_PARK 

:Z_N4
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N4
056D:   actor 1@ defined
else_jump @Z_N4
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N4
03A3:   actor 1@ male
else_jump @Z_N4
not Actor.Driving(1@)
else_jump @Z_N4
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N4
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N4
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N4
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N4
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N4
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N4
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N4
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N4
$ONMISSION == 0 
else_jump @Z_N4
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1 

:run_to_actorN4
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO4
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN4' time 5000 flag 1  //Эй, тут одного паренька подставить нужно, не желаешь помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y4
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N4
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
0A1D: AS_actor $PLAYER_ACTOR rotate_to_and_look_at_actor 1@
wait 500
0812: AS_actor 1@ perform_animation "ATM" IFP "PED" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time 2008  // versionB
wait 2008
00BC: show_text_highpriority GXT 'CHDZ4' time 5000 flag 1  //Заложи в автомобиль мешочек с марихуаной.
018A: 8@ = create_checkpoint_at 1836.7244 -1854.676 13.3828
08FB: set_checkpoint 8@ type_to 0
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
Model.Load(#CSHER)
Model.Load(#BUCCANEE)
04ED: load_animation  "ON_LOOKERS"
04ED: load_animation  "INT_HOUSE"
038B: load_requested_models
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:NEAR_CAR
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 1821.6222 -1779.0906 13.3828 radius 100.0 100.0 100.0
else_jump @NEAR_CAR
Marker.Disable(8@)
14@ = Actor.Create(CivMale, #CSHER, 1836.6097, -1858.0148, 13.3828)
Actor.Angle(14@) = 2.2382
0812: AS_actor 14@ perform_animation "wash_up" IFP "INT_HOUSE" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1  // versionB
15@ = Car.Create(#BUCCANEE, 1836.7244, -1854.676, 13.3828)
Car.Angle(15@) = 0.528
Car.DoorStatus(15@) = 4
04E1: open_and_freeze_car_trunk 15@
00BC: show_text_highpriority GXT 'CHDD4' time 5000 flag 1  //Отвлеки человека, который роется в багажнике.
Marker.CreateAboveActor(18@, 14@)
Marker.SetColor(18@, 1)

:OT_ACT
wait 0
00F3:   actor $PLAYER_ACTOR near_actor 14@ radius 6.0 6.0 sphere 0 on_foot
else_jump @OT_ACT_FAIL
0687: clear_actor $PLAYER_ACTOR task
wait 500
0605: actor $PLAYER_ACTOR perform_animation "shout_01" IFP "ON_LOOKERS" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1
00BC: show_text_highpriority GXT 'CHDD1' time 5000 flag 1  //(CJ): Эй!
Marker.Disable(18@)
wait 1000
0687: clear_actor 14@ task
0687: clear_actor $PLAYER_ACTOR task
0A1D: AS_actor 14@ rotate_to_and_look_at_actor $PLAYER_ACTOR
wait 500
0605: actor $PLAYER_ACTOR perform_animation "IDLE_CHAT" IFP "PED" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1
00BC: show_text_highpriority GXT 'CHDD2' time 5000 flag 1  //(CJ): Тут.. Эм... Неподалеку человека избивают. Надо разобраться.
wait 3000
05DE: AS_actor 14@ walk_around_ped_path

:NEAR_OTACT
wait 0
80F3:  not actor 14@ near_actor $PLAYER_ACTOR radius 10.0 10.0 sphere 0 on_foot
else_jump @NEAR_OTACT_FAIL
00BC: show_text_highpriority GXT 'CHDD3' time 5000 flag 1  //Заложи наркотики в багажник автомобиля.

:END_NC4
wait 0
0101:   actor $PLAYER_ACTOR in_sphere 1836.5685 -1858.3047 13.3828 radius 1.5 1.5 10.5 sphere 1.5 stopped
else_jump @END_NC4_FAIL
05D4: AS_actor $PLAYER_ACTOR rotate_angle 358.8427
wait 500
0812: AS_actor $PLAYER_ACTOR perform_animation "wash_up" IFP "INT_HOUSE" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time 2000  // versionB
0615: define_AS_pack_begin 18@ 
0605: actor -1 perform_animation "ROADCROSS" IFP "PED" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0605: actor -1 perform_animation "wash_up" IFP "INT_HOUSE" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 18@ 
0618: assign_actor $PLAYER_ACTOR to_AS_pack 18@ 
061B: remove_references_to_AS_pack 18@
wait 5000
Car.RemoveReferences(15@)
Actor.RemoveReferences(14@)
Model.Destroy(#CSHER)
Model.Destroy(#BUCCANEE)
04EF: release_animation  "ON_LOOKERS"
04EF: release_animation  "INT_HOUSE"
0394: play_music 2
17@ = 4000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:KEY_N4
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y4
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO4
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN4
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:OT_ACT_FAIL
if or
gosub @WASTED_OR_BUSTED
Actor.Dead(14@)
else_jump @OT_ACT
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
00BC: show_text_highpriority GXT 'CHEF4' time 5000 flag 1 //Нужно было подставить человека, а не убить!
$ONMISSION = 0
Car.RemoveReferences(15@)
Actor.RemoveReferences(14@)
Model.Destroy(#CSHER)
Model.Destroy(#BUCCANEE)
04EF: release_animation  "ON_LOOKERS"
04EF: release_animation  "INT_HOUSE"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER
                   
:NEAR_OTACT_FAIL
if or
gosub @WASTED_OR_BUSTED
Actor.Dead(14@)
else_jump @NEAR_OTACT
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
00BC: show_text_highpriority GXT 'CHEF4' time 5000 flag 1 //Нужно было подставить человека, а не убить!
$ONMISSION = 0
Car.RemoveReferences(15@)
Actor.RemoveReferences(14@)
Model.Destroy(#CSHER)
Model.Destroy(#BUCCANEE)
04EF: release_animation  "ON_LOOKERS"
04EF: release_animation  "INT_HOUSE"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:END_NC4_FAIL
if or
Actor.Dead(14@)
Car.Wrecked(15@)
gosub @WASTED_OR_BUSTED
else_jump @END_NC4
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
Car.RemoveReferences(15@)
Actor.RemoveReferences(14@)
Model.Destroy(#CSHER)
Model.Destroy(#BUCCANEE)
04EF: release_animation  "ON_LOOKERS"
04EF: release_animation  "INT_HOUSE"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER 

:Z_N5
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N5
056D:   actor 1@ defined
else_jump @Z_N5
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N5
03A3:   actor 1@ male
else_jump @Z_N5
not Actor.Driving(1@)
else_jump @Z_N5
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N5
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N5
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N5
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N5
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N5
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N5
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N5
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N5
$ONMISSION == 0 
else_jump @Z_N5
Marker.CreateAboveActor(27@,1@)

:run_to_actorN5
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO5
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN5' time 5000 flag 1  //Хочу испортить жизнь одному бизнесмену. Не хочешь помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y5
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N5
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CHDZ5' time 5000 flag 1  //Отправляйся на склад и подожги весь товар c помощью огнемета
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
018A: 8@ = create_checkpoint_at 2771.9004 -2456.4568 13.6375
08FB: set_checkpoint 8@ type_to 0
Model.Load(1224)
Model.Load(#ROCKETLA)
038B: load_requested_models
01B2: give_actor $PLAYER_ACTOR weapon 35 ammo 20
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:NEAR_CKLAD                                             
wait 0
0101:   actor $PLAYER_ACTOR in_sphere 2758.6182 -2434.6416 13.4987 radius 1.5 1.5 10.5 sphere 1.5 stopped 
else_jump @NEAR_CKLAD
not Actor.Driving($PLAYER_ACTOR)
else_jump @EXIT_CAR_LS
00BC: show_text_highpriority GXT 'CHZZ5' time 5000 flag 1  //Разрушь все коробки, находящиеся на складе
16@ = Object.Create(1224, 2632.2292, -2380.6074, 16.3403)
17@ = Object.Create(1224, 2633.9109, -2443.9607, 12.6328)
18@ = Object.Create(1224, 2700.28, -2465.679, 16.5937)
19@ = Object.Create(1224, 2717.4619, -2517.4167, 16.3672)
20@ = Object.Create(1224, 2770.0867, -2527.7551, 12.6393)
21@ = Object.Create(1224, 2777.8801, -2503.0686, 12.6499)
22@ = Object.Create(1224, 2776.8555, -2445.8096, 12.6363)
23@ = Object.Create(1224, 2798.585, -2418.5833, 12.631)
24@ = Object.Create(1224, 2766.1145, -2373.8442, 17.9217)
25@ = Object.Create(1224, 2828.7249, -2404.2073, 19.4104)
26@ = 180000
27@ = 10 
0AB1: call_scm_func @SetTimer 3 VARNUMBER = 26 TYPE = 1 GXT = @StatusTextA
0AB1: call_scm_func @AddStatusText 4 VARNUMBER = 27 TYPE = 0 GXT = @StatusTextB LINE = 0
129@ = 0
130@ = 0
131@ = 0
132@ = 0
133@ = 0
134@ = 0
135@ = 0
136@ = 0
137@ = 0
138@ = 0
139@ = 0
01B9: set_actor $PLAYER_ACTOR armed_weapon_to 35
0992: set_player $PLAYER_CHAR weapons_scrollable 0

:OBJ_1LS
wait 0
if and
130@ == 0
0366: object 16@ blown_up
else_jump @OBJ_2LS
27@ -= 1
129@ += 1
130@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_2LS
if and
131@ == 0
0366: object 17@ blown_up
else_jump @OBJ_3LS
$AF3KAKA -= 1
129@ += 1
131@ = 1
0663: printint "BOX_BROKE" 129@
 
:OBJ_3LS
if and
132@ == 0
0366: object 18@ blown_up
else_jump @OBJ_4LS
$AF3KAKA -= 1
129@ += 1
132@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_4LS
if and
133@ == 0
0366: object 19@ blown_up
else_jump @OBJ_5LS
$AF3KAKA -= 1
129@ += 1
133@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_5LS
if and
134@ == 0
0366: object 20@ blown_up
else_jump @OBJ_6LS
27@ -= 1
129@ += 1
134@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_6LS
if and
135@ == 0
0366: object 21@ blown_up
else_jump @OBJ_8LS
27@ -= 1
129@ += 1
135@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_8LS
if and
136@ == 0
0366: object 22@ blown_up
else_jump @OBJ_10LS
27@ -= 1
129@ += 1
136@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_10LS
if and
137@ == 0
0366: object 23@ blown_up
else_jump @OBJ_11LS
27@ -= 1
129@ += 1
137@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_11LS
if and
138@ == 0
0366: object 24@ blown_up
else_jump @OBJ_12LS
27@ -= 1
129@ += 1
138@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_12LS
if and
139@ == 0
0366: object 25@ blown_up
else_jump @OBJ_ENDIKLLS
27@ -= 1
129@ += 1
139@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_ENDIKLLS
if or
129@ == 10
gosub @WASTED_OR_BUSTED
else_jump @OBJ_TIMERLS
0394: play_music 2
17@ = 8000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
0992: set_player $PLAYER_CHAR weapons_scrollable 1
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
0AB1: call_scm_func @RemoveStatusText 1 VARNUMBER = 27
0AB1: call_scm_func @StopTimer 1 VARNUMBER = 26
Marker.Disable(8@)
Object.RemoveReferences(16@)
Object.RemoveReferences(17@)
Object.RemoveReferences(18@)
Object.RemoveReferences(19@)
Object.RemoveReferences(20@)
Object.RemoveReferences(21@)
Object.RemoveReferences(22@)
Object.RemoveReferences(23@)
Object.RemoveReferences(24@)
Object.RemoveReferences(25@)
Model.Destroy(1224)
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:EXIT_CAR_LS
03E5: show_text_box 'HELPA'  // Выйдите из машины, чтобы начать задание.
wait 1000
jump @NEAR_CKLAD 

:OBJ_TIMERLS
if or
26@ == 0
gosub @WASTED_OR_BUSTED
else_jump @OBJ_1LS
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
0992: set_player $PLAYER_CHAR weapons_scrollable 1
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0AB1: call_scm_func @RemoveStatusText 1 VARNUMBER = 27
0AB1: call_scm_func @StopTimer 1 VARNUMBER = 26
0663: printint "TIME" 9@
Marker.Disable(8@)
Object.RemoveReferences(16@)
Object.RemoveReferences(17@)
Object.RemoveReferences(18@)
Object.RemoveReferences(19@)
Object.RemoveReferences(20@)
Object.RemoveReferences(21@)
Object.RemoveReferences(22@)
Object.RemoveReferences(23@)
Object.RemoveReferences(24@)
Object.RemoveReferences(25@)
Model.Destroy(1224)
Model.Destroy(#ROCKETLA)
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N5
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y5
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO5
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN5
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:Z_N6
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N6
056D:   actor 1@ defined
else_jump @Z_N6
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N6
03A3:   actor 1@ male
else_jump @Z_N6
not Actor.Driving(1@)
else_jump @Z_N6
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N6
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N6
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N6
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N6
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N6
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N6
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N6
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N6
$ONMISSION == 0 
else_jump @Z_N6
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN6
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO6
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN6' time 5000 flag 1  //Нужно передать посылку одному человеку? Ты можешь помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться. 
$ONMISSION = 1                      

:KEY_Y6
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N6
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Model.Load(3052)
038B: load_requested_models
fade 0 1000 
wait 1500
Actor.StorePos($PLAYER_ACTOR, 67@, 68@, 69@)
68@ +=2.0
70@ = Object.Create(3052, 67@, 68@, 69@)
08E9: set_object 70@ liftable 1
07C9: AS_actor $PLAYER_ACTOR walk_to_object 70@ then_lift_and_hold_in_hands
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:FIDE_END
wait 0
0737:   actor $PLAYER_ACTOR lifting_object 70@
else_jump @FIDE_END
fade 1 1000 
wait 1000
08E9: set_object 70@ liftable 0
00BC: show_text_highpriority GXT 'CEEE6' time 5000 flag 1  //Дождитесь человека, который должен получить посылку.
0209: 17@ = random_int_in_ranges 10000 25000
wait 17@

:FIND_A
wait 0
Actor.StorePos($PLAYER_ACTOR, 48@, 49@, 50@)
0AE1: 2@ = random_actor_near_point 48@ 49@ 50@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @FIND_A
056D:   actor 2@ defined
else_jump @FIND_A
089F: get_actor 2@ pedtype_to 30@
30@ == 4
else_jump @FIND_A
03A3:   actor 2@ male
else_jump @FIND_A
not Actor.Driving(2@)
else_jump @FIND_A

:WALK
Actor.StorePos($PLAYER_ACTOR, 71@, 72@, 73@) 
07CD: AS_actor 2@ walk_to 71@ 72@ 73@ stop_with_angle 270.0 within_radius 4.0

:POSLKA_END
wait 0
0105:   actor 2@ near_actor $PLAYER_ACTOR radius 2.0 2.0 2.0 sphere 0 on_foot
else_jump @WALK
Object.Destroy(70@)
Model.Destroy(3052)
0687: clear_actor $PLAYER_ACTOR task
0394: play_music 2
17@ = 1500
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
Actor.RemoveReferences(40@)
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER 

:KEY_N6
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y6 
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO6
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN6
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random 

:Z_N7
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N7
056D:   actor 1@ defined
else_jump @Z_N7
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N7
03A3:   actor 1@ male
else_jump @Z_N7
not Actor.Driving(1@)
else_jump @Z_N7
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N7
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N7
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N7
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N7
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N7
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N7
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N7
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N7
$ONMISSION == 0 
else_jump @Z_N7
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN7
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO7
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN7' time 5000 flag 1  //Я работаю курьером, мне нужно передать цветы одной девушки, но я не успеваю! Вы можете мне помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1                       

:KEY_Y7
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N7
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CHDZ7' time 5000 flag 1  //Отправляйся в Конференц-центр.
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
018A: 8@ = create_checkpoint_at 1156.9996 -1721.0988 13.9531
08FB: set_checkpoint 8@ type_to 0
Model.Load(#flowera)
04ED: load_animation  "KISSING"
038B: load_requested_models
01B2: give_actor $PLAYER_ACTOR weapon 14 ammo 1 // Load the weapon model before using this
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:NEAR_FLOWERS
wait 0
0101:   actor $PLAYER_ACTOR in_sphere 1156.9996 -1721.0988 13.9531 radius 1.5 1.5 10.5 sphere 1.5 stopped
else_jump @NEAR_FLOWERS

:DRIVE1
Actor.Driving($PLAYER_ACTOR)
else_jump @NEAR_FLOWERS
00BC: show_text_highpriority GXT 'EEE7' time 1000 flag 1  //Стой здесь, пока не появится девушка, которой нужно отдать цветы. 
Actor.StorePos($PLAYER_ACTOR, 2@, 3@, 4@)
0AE1: 1@ = random_actor_near_point 2@ 3@ 4@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @NEAR_FLOWERS
056D:   actor 1@ defined
else_jump @NEAR_FLOWERS
089F: get_actor 1@ pedtype_to 30@
30@ == 5
else_jump @NEAR_FLOWERS
not Actor.Driving(1@)
else_jump @NEAR_FLOWERS
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @NEAR_FLOWERS
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @NEAR_FLOWERS
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @NEAR_FLOWERS
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @NEAR_FLOWERS
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @NEAR_FLOWERS
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @NEAR_FLOWERS
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @NEAR_FLOWERS
Marker.CreateAboveActor(27@,1@)
Marker.SetColor(27@, 1)
00BC: show_text_highpriority GXT 'CHDE7' time 5000 flag 1  //Передай девушке цветы.
Marker.Disable(8@)


:FLOWERS_END
wait 0
0105:   actor $PLAYER_ACTOR near_actor 1@ radius 2.0 2.0 2.0 sphere 0 on_foot
else_jump @FLOWERS_END_FAIL
0687: clear_actor $PLAYER_ACTOR task
0687: clear_actor 1@ task
0992: set_player $PLAYER_CHAR weapons_scrollable 0
01B9: set_actor $PLAYER_ACTOR armed_weapon_to 14
0639: AS_actor 1@ rotate_to_actor $PLAYER_ACTOR
0639: AS_actor $PLAYER_ACTOR rotate_to_actor 1@  
0605: actor $PLAYER_ACTOR perform_animation "gift_give" IFP "KISSING" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 5330
0605: actor 1@ perform_animation "gift_get" IFP "KISSING" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 5330  
04EF: release_animation "KISSING"
wait 5000
0992: set_player $PLAYER_CHAR weapons_scrollable 1
01B2: give_actor 1@ weapon 14 ammo 1 // Load the weapon model before using this
01B9: set_actor 1@ armed_weapon_to 14
0555: remove_weapon 14 from_actor $PLAYER_ACTOR
0394: play_music 2
17@ = 1000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:FLOWERS_END_FAIL
if or
856D:  not actor 1@ defined
Actor.Dead(1@)
8491:  not actor $PLAYER_ACTOR has_weapon 14
gosub @WASTED_OR_BUSTED
else_jump @FLOWERS_END
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
Marker.Disable(27@)
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N7
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y7 
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO7
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN7
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random  

:Z_N8
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N8
056D:   actor 1@ defined
else_jump @Z_N8
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N8
03A3:   actor 1@ male
else_jump @Z_N8
not Actor.Driving(1@)
else_jump @Z_N8
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N8
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N8
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N8
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N8
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N8
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N8
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N8
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N8
$ONMISSION == 0 
else_jump @Z_N8
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN8
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO8
05C1: AS_actor 1@ speak_from_audio_table 166
Actor.StorePos(1@, 90@, 91@, 92@)
0665: get_actor 1@ model_to 93@
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN9' time 5000 flag 1  //Мне кажется, моя девушка мне изменяет. Ты можешь помочь мне выявить её ухажера?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1                       

:KEY_Y8
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N8
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CHDZ9' time 5000 flag 1  //Отправляйся к причалу.
Model.Load(233)
Model.Load(185)
038B: load_requested_models
018A: 8@ = create_checkpoint_at 374.1707 -1942.5436 7.6719
08FB: set_checkpoint 8@ type_to 0
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
Model.Load(233)
Model.Load(185)
04ED: load_animation  "KISSING"
038B: load_requested_models
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:NEAR_PR
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 374.1707 -1942.5436 7.6719 radius 100.0 100.0 100.0
else_jump @NEAR_PR
Marker.Disable(8@)
2@ = Actor.Create(4, 185, 386.1745, -2034.2792, 7.8359)
3@ = Actor.Create(5, 233, 386.4089, -2035.2212, 7.8359)
Actor.Angle(2@) = 184.3579
Actor.Angle(3@) = 358.8916
wait 500
0615: define_AS_pack_begin 18@
0605: actor -1 perform_animation "Grlfrd_Kiss_02" IFP "KISSING" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1
0618: assign_actor 3@ to_AS_pack 18@
0643: set_AS_pack 18@ loop 1
//*************************//
Marker.CreateAboveActor(97@, 2@)
Marker.CreateAboveActor(98@, 3@)
00BC: show_text_highpriority GXT 'CHDE9' time 5000 flag 1  //Сфотографируй измену. Не подходи к ним слишком близко.

:PHOTO
wait 0
if and
04C5:   actor 2@ photographed
04C5:   actor 3@ photographed
else_jump @PHOTO_FAIL
Marker.Disable(97@)
Marker.Disable(98@)                                                            
00BC: show_text_highpriority GXT 'CEDE9' time 5000 flag 1  //Передай фотографию человеку.
018A: 8@ = create_checkpoint_at 90@ 91@ 92@
08FB: set_checkpoint 8@ type_to 0
Model.Load(93@)
038B: load_requested_models
jump @PHOTO_END1

:PHOTO_END1
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 90@ 91@ 92@ radius 100.0 100.0 100.0
else_jump @PHOTO_END1
1@ = Actor.Create(CivMale, 93@, 90@, 91@, 92@)
jump @PHOTO_END2

:PHOTO_FAIL
if or
gosub @WASTED_OR_BUSTED
00F2:   actor $PLAYER_ACTOR near_actor 2@ radius 20.0 20.0 sphere 0
00F2:   actor $PLAYER_ACTOR near_actor 3@ radius 20.0 20.0 sphere 0
else_jump @PHOTO
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
0616: define_AS_pack_end 18@
0616: define_AS_pack_end 19@
061B: remove_references_to_AS_pack 18@ 
061B: remove_references_to_AS_pack 19@
Marker.Disable(97@)
Marker.Disable(98@)
Actor.RemoveReferences(2@)
Actor.RemoveReferences(3@) 
Marker.Disable(8@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:PHOTO_END2
wait 0
0105:   actor $PLAYER_ACTOR near_actor 1@ radius 2.0 2.0 2.0 sphere 0 on_foot
else_jump @PHOTO_END2_FAIL
Marker.Disable(8@)
0687: clear_actor $PLAYER_ACTOR task
0687: clear_actor 1@ task
0639: AS_actor 1@ rotate_to_actor $PLAYER_ACTOR
0639: AS_actor $PLAYER_ACTOR rotate_to_actor 1@  
0605: actor $PLAYER_ACTOR perform_animation "ATM" IFP "PED" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 2008  
wait 2008
0394: play_music 2
17@ = 5000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
Marker.Disable(94@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:PHOTO_END2_FAIL
if or
856D:  not actor 1@ defined
Actor.Dead(1@)
8491:  not actor $PLAYER_ACTOR has_weapon 14
gosub @WASTED_OR_BUSTED
else_jump @PHOTO_END2
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
Marker.Disable(27@)
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N8
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y8 
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO8
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN8
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:Z_N9
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N9
056D:   actor 1@ defined
else_jump @Z_N9
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N9
03A3:   actor 1@ male
else_jump @Z_N9
not Actor.Driving(1@)
else_jump @Z_N9
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N9
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N9
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N9
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N9
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N9
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N9
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N9
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N9
$ONMISSION == 0 
else_jump @Z_N9
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN9
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO9
05C1: AS_actor 1@ speak_from_audio_table 166
0665: get_actor 1@ model_to 93@
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CDN10' time 5000 flag 1  //Нужно украсть одну вещь из дома, ты можешь помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1                       

:KEY_Y9
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N9
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CHZ9' time 5000 flag 1  //Ограбь дом в районе Иделвуд.
0A40: 2@ = create_entrance_marker_at 2066.9763 -1656.5579 15.075 color 14
018A: 8@ = create_checkpoint_at 2066.9763 -1656.5579 14.075
08FB: set_checkpoint 8@ type_to 0
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:ENTER
wait 0
00ED:   actor $PLAYER_ACTOR sphere 0 near_point 2066.9763 -1656.5579 radius 2.0 2.0 on_foot
else_jump @ENTER
Marker.Disable(8@)
0A41: destroy_entrance_marker 2@
fade 0 1000 
wait 1500
select_interior 2
0860: link_actor $PLAYER_ACTOR to_interior 2
Actor.PutAt($PLAYER_ACTOR, 224.7515, 1240.0166, 1082.1406)
3@ = Pickup.Create(1581, 3, 224.871, 1253.1106, 1082.1406)
03DC: 4@ = create_marker_above_pickup 3@
Marker.SetColor(4@, 1)
fade 1 1000 
wait 1000
00BC: show_text_highpriority GXT 'CDZ10' time 5000 flag 1  //Подбери вещь, которая нужна человеку.
08E7: disable_entrance_markers 1

:PIK_UP
wait 0
Pickup.Picked_up(3@)
else_jump @PIK_UP
0A40: 2@ = create_entrance_marker_at 2066.9763 -1656.5579 15.075 color 14
018A: 8@ = create_checkpoint_at 2066.9763 -1656.5579 14.075
08FB: set_checkpoint 8@ type_to 0
00BC: show_text_highpriority GXT 'CDE10' time 5000 flag 1  //Направляйся к выходу
Model.Load(93@)
038B: load_requested_models

:EXIT
wait 0
00ED:   actor $PLAYER_ACTOR sphere 0 near_point 226.6236 1240.0719 radius 2.0 2.0 on_foot
else_jump @EXIT
Marker.Disable(8@)
0A41: destroy_entrance_marker 2@
fade 0 1000 
wait 1500
select_interior 0
0860: link_actor $PLAYER_ACTOR to_interior 0
Actor.PutAt($PLAYER_ACTOR, 2069.939, -1656.6908, 13.5469)
1@ = Actor.Create(CivMale, 93@, 2071.8398, -1656.8169, 13.5469)
Actor.Angle(1@) = 92.6985
fade 1 1000 
wait 1000
0687: clear_actor $PLAYER_ACTOR task
0687: clear_actor 1@ task
0639: AS_actor 1@ rotate_to_actor $PLAYER_ACTOR
0639: AS_actor $PLAYER_ACTOR rotate_to_actor 1@  
0605: actor $PLAYER_ACTOR perform_animation "ATM" IFP "PED" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 2008  
wait 2008
0394: play_music 2
17@ = 10000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
Marker.Disable(94@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:KEY_N9
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y9 
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO9
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN9
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:Z_N10
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N10
056D:   actor 1@ defined
else_jump @Z_N10
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N10
03A3:   actor 1@ male
else_jump @Z_N10
not Actor.Driving(1@)
else_jump @Z_N10
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N10
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N10
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N10
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N10
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N10
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N10
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N10
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N10
$ONMISSION == 0 
else_jump @Z_N10
Marker.CreateAboveActor(27@,1@)

:run_to_actorN10
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO10
05C1: AS_actor 1@ speak_from_audio_table 166
0665: get_actor 1@ model_to 93@
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CZN10' time 5000 flag 1  //Сейчас на Першинской площади идет выбор нового мэра, ты можешь сорвать эти выборы?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1                       

:KEY_Y10
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N10
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CHZ10' time 5000 flag 1  //Сорви выборы на першинской площади.
018A: 88@ = create_checkpoint_at 1465.4938 -1620.7065 14.0393
08FB: set_checkpoint 88@ type_to 0
Model.Load(#SWMYRI)
Model.Load(#MALE01)
Model.Load(#BFYRI)
Model.Load(#BMORI)
Model.Load(#BFYST)
Model.Load(#HFORI)
Model.Load(#WBDYG2)
Model.Load(#WMYCON)
Model.Load(#HMORI)
Model.Load(#OFYST)
Model.Load(#WFYSTEW)
Model.Load(#BMYBOUN)
Model.Load(#WMYBOUN)
038B: load_requested_models
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"


:NEAR_SQ
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 1523.8416 -1600.6454 13.5469 radius 100.0 100.0 100.0
else_jump @NEAR_SQ
0@ = Actor.Create(4, #SWMYRI, 1461.564, -1620.0852, 14.7891)//0
1@ = Actor.Create(4, #MALE01, 1467.8392, -1626.1411, 14.0469)
2@ = Actor.Create(5, #BFYRI, 1468.4001, -1624.0907, 14.0469)
3@ = Actor.Create(4, #BMORI, 1466.4825, -1623.3379, 14.0469)
4@ = Actor.Create(5, #BFYST, 1468.3899, -1622.3949, 14.0469)
5@ = Actor.Create(5, #HFORI, 1467.5103, -1620.2651, 14.0393)
6@ = Actor.Create(4, #WBDYG2, 1468.8114, -1617.3979, 14.0393)
7@ = Actor.Create(4, #WMYCON, 1466.9537, -1618.6088, 14.0393)
8@ = Actor.Create(4, #HMORI, 1468.1786, -1615.6106, 14.0393)
9@ = Actor.Create(5, #OFYST, 1470.3776, -1618.0208, 14.0393)
10@ = Actor.Create(5, #WFYSTEW, 1465.5068, -1619.6488, 14.0393) 
11@ = Actor.Create(4, #BMYBOUN, 1463.8839, -1622.4506, 14.1029)//1
12@ = Actor.Create(4, #WMYBOUN, 1463.9088, -1616.3833, 14.0889)//2
Actor.Angle(0@) = 261.9496
Actor.Angle(1@) = 66.3785
Actor.Angle(2@) = 68.2585
Actor.Angle(3@) = 68.5719
Actor.Angle(4@) = 90.1921
Actor.Angle(5@) = 90.8187
Actor.Angle(6@) = 122.1524
Actor.Angle(7@) = 123.0924
Actor.Angle(8@) = 124.0324
Actor.Angle(9@) = 94.5788
Actor.Angle(10@) = 94.5788
Actor.Angle(11@) = 269.7829
Actor.Angle(12@) = 270.8188
//
0615: define_AS_pack_begin 18@
0605: actor -1 perform_animation "IDLE_CHAT" IFP "PED" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1
0618: assign_actor 0@ to_AS_pack 18@
0643: set_AS_pack 18@ loop 1
//
00BC: show_text_highpriority GXT 'CHE10' time 5000 flag 1  //Спровоцируй драку в толпе, ударив любого находящегося на площади человека.

:DAMAGE
wait 0
if or
gosub @DAMAGE_A
gosub @DAMAGE_B
else_jump @DAMAGE_FAIL
not Actor.Driving($PLAYER_ACTOR)
else_jump @DAMAGE_FAIL
00BC: show_text_highpriority GXT 'CHX10' time 3000 flag 1  //(Голос из толпы): Эй, кто меня ударил?
wait 3000
00BC: show_text_highpriority GXT 'CHX11' time 5000 flag 1  //(Голос из толпы): Ты это мне?!
wait 1000
05E2: AS_actor 1@ kill_actor 2@
05E2: AS_actor 2@ kill_actor 1@
05E2: AS_actor 3@ kill_actor 4@
05E2: AS_actor 4@ kill_actor 3@
05E2: AS_actor 5@ kill_actor 6@
05E2: AS_actor 6@ kill_actor 7@
05E2: AS_actor 7@ kill_actor 8@
05E2: AS_actor 8@ kill_actor 7@
05E2: AS_actor 9@ kill_actor 10@
05E2: AS_actor 10@ kill_actor 9@
05E2: AS_actor 11@ kill_actor 6@
05E2: AS_actor 12@ kill_actor 5@
05C3: AS_actor 0@ hands_cower
Marker.Disable(88@)
0394: play_music 2
Actor.StorePos($PLAYER_ACTOR, 55@, 66@, 77@)
17@ = 15000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @DESTROY

:DAMAGE_FAIL
if or
051A:   actor 0@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 11@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 12@ damaged_by_actor $PLAYER_ACTOR
gosub @WASTED_OR_BUSTED
else_jump @DAMAGE_GCAR
Marker.Disable(88@)
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @DESTROY

:DAMAGE_GCAR
Actor.Driving($PLAYER_ACTOR)
else_jump @DAMAGE
99@ = Actor.CurrentCar($PLAYER_ACTOR)
if or
gosub @DAMAGE_C
gosub @DAMAGE_D
else_jump @DAMAGE
Marker.Disable(88@)
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @DESTROY

:DESTROY
wait 0
80FE:  not actor $PLAYER_ACTOR sphere 0 in_sphere 55@ 66@ 77@ radius 100.0 100.0 100.0
else_jump @DESTROY
Actor.RemoveReferences(0@)
Actor.RemoveReferences(1@)
Actor.RemoveReferences(2@)
Actor.RemoveReferences(3@)
Actor.RemoveReferences(4@)
Actor.RemoveReferences(5@)
Actor.RemoveReferences(6@)
Actor.RemoveReferences(7@)
Actor.RemoveReferences(8@)
Actor.RemoveReferences(9@)
Actor.RemoveReferences(10@)
Actor.RemoveReferences(11@)
Actor.RemoveReferences(12@)
Model.Destroy(#SWMYRI)
Model.Destroy(#MALE01)
Model.Destroy(#BFYRI)
Model.Destroy(#BMORI)
Model.Destroy(#BFYST)
Model.Destroy(#HFORI)
Model.Destroy(#WBDYG2)
Model.Destroy(#WMYCON)
Model.Destroy(#HMORI)
Model.Destroy(#OFYST)
Model.Destroy(#WFYSTEW)
Model.Destroy(#BMYBOUN)
Model.Destroy(#WMYBOUN)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
jump @TIMER

:KEY_N10
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y10
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136 
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@ 
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO10
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN10
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:Z_N11
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N11
056D:   actor 1@ defined
else_jump @Z_N11
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N11
03A3:   actor 1@ male
else_jump @Z_N11
not Actor.Driving(1@)
else_jump @Z_N11
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N11
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N11
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N11
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N11
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N11
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N11
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N11
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N11
$ONMISSION == 0 
else_jump @Z_N11
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN11
wait 0
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @run_to_actorN11_NO
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CDN11' time 5000 flag 1  //Чувак, мне нужно угнать автомобиль для участия в гонках. Не поможешь? //!!!!!
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y11
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N11
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CDZ11' time 5000 flag 1  //Найди и угони автомобиль марки Banshee. //!!!!!
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:GCAR
wait 0
00DD:   actor $PLAYER_ACTOR driving_car_with_model #BANSHEE
else_jump @GCAR
7@ = Actor.CurrentCar($PLAYER_ACTOR)
00BC: show_text_highpriority GXT 'CHDE1' time 5000 flag 1  //Отвези автомобиль в гараж заказчика
018A: 8@ = create_checkpoint_at -2108.6848 -16.5508 35.0391
08FB: set_checkpoint 8@ type_to 0
Garage.Activate('BRGSFSE')
Garage.Open('BRGSFSE')
Garage.ChangeType('BRGSFSE', 32)

:END_Z11
wait 0
0101:   actor $PLAYER_ACTOR in_sphere -2108.6848 -16.5508 35.0391 radius 1.5 1.5 10.5 sphere 1.5 stopped 
else_jump @END_Z11
Actor.InCar($PLAYER_ACTOR, 7@)
else_jump @END_Z11_F
fade 0 1000 
wait 1500
0633: AS_actor $PLAYER_ACTOR exit_car
wait 2000
Actor.PutAt($PLAYER_ACTOR, -2098.2249, -16.1157, 34.3203)
Actor.Angle($PLAYER_ACTOR) = 271.8526
fade 1 1000 
wait 1000
Garage.Deactivate('BRGSFSE')
Garage.Close('BRGSFSE')
0394: play_music 2
17@ = 3000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
0632: release_group $PLAYER_GROUP
Car.RemoveReferences(7@)
Marker.Disable(8@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:END_Z11_F
if or
gosub @WASTED_OR_BUSTED
Car.Wrecked(7@)
else_jump @END_Z11
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
0632: release_group $PLAYER_GROUP
Car.RemoveReferences(7@)
Marker.Disable(8@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N11
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y11
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1 // Вы отказались от поручения!
$ONMISSION = 0
05DE: AS_actor 1@ walk_around_ped_path
Marker.Disable(27@)
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorN11_NO
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN11
Marker.Disable(27@)
jump @random

:Z_N12
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N12
056D:   actor 1@ defined
else_jump @Z_N12
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N12
03A3:   actor 1@ male
else_jump @Z_N12
not Actor.Driving(1@)
else_jump @Z_N12
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N12
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N12
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N12
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N12
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N12
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N12
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N12
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N12
$ONMISSION == 0 
else_jump @Z_N2
Marker.CreateAboveActor(27@,1@)

:run_to_actorN12
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO12
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN2' time 5000 flag 1  //Эй, парень, мне нужно убить одного человека, он слишком много знает.
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y12
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N12
00BC: show_text_highpriority GXT 'CHDZ2' time 5000 flag 1  //Отправляйся к зданию суда и убей свидетеля.
018A: 8@ = create_checkpoint_at -2651.7886 -26.0371 6.1328
08FB: set_checkpoint 8@ type_to 0
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
Model.Load(#WMYRI)
Model.Load(#CELLPHONE)
038B: load_requested_models
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:CACTS
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere -2608.1309 -50.7769 4.1797 radius 100.0 100.0 100.0
else_jump @CACTS
Marker.Disable(8@)
12@ = Actor.Create(CivMale, #WMYRI, -2651.7886, -26.0371, 6.1328)
Actor.Angle(12@) = 172.7935
0729: AS_actor 12@ hold_cellphone 1
Marker.CreateAboveActor(13@, 12@)
00BC: show_text_highpriority GXT 'CHDE2' time 5000 flag 1  //Убей свидетеля и скройся с места преступления.

:BEG_GUNS
wait 0
00F2:   actor $PLAYER_ACTOR near_actor 12@ radius 6.0 6.0 sphere 0
else_jump @END_CACTS
0470: 76@ = actor $PLAYER_ACTOR current_weapon
if or
76@ == 0
76@ == 1
76@ == 2
76@ == 3
76@ == 6
76@ == 7
else_jump @FAIL_COPSS
jump @END_CACTS

:FAIL_COPSS
0729: AS_actor 12@ hold_cellphone 0
00BC: show_text_highpriority GXT 'CHEE2' time 5000 flag 1  //Помогите, у этого человека в руках оружие!
05DA: AS_actor 12@ run_away_in_panic_from -2751.5359 -63.9889 7.1802 away_radius 100.0 timelimit 999999

:COP_FINDS
Actor.StorePos(12@, 78@, 79@, 80@)
0AE1: 77@ = random_actor_near_point 78@ 79@ 80@ in_radius 15.0 find_next 1 pass_deads 1
056D:   actor 77@ defined
else_jump @GUN_DIES
089F: get_actor 77@ pedtype_to 81@
81@ == 6
else_jump @GUN_DIES
010D: set_player $PLAYER_CHAR wanted_level_to 2
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
00BC: show_text_highpriority GXT 'CHEF2' time 5000 flag 1 //Вас заметили полицейские!
$ONMISSION = 0
Marker.Disable(13@)
Model.Destroy(#WMYRI)
Model.Destroy(#CELLPHONE)
wait 5000
Actor.RemoveReferences(12@)
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:END_CACTS
Actor.Dead(12@)
else_jump @BEG_GUNS
Marker.Disable(13@)
Actor.RemoveReferences(12@)
Model.Destroy(#WMYRI)
Model.Destroy(#CELLPHONE)
010D: set_player $PLAYER_CHAR wanted_level_to 2
0394: play_music 2
17@ = 5000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:GUN_DIES
wait 0
Actor.Dead(12@)
else_jump @GUN_DIES
Marker.Disable(13@)
Actor.RemoveReferences(12@)
Model.Destroy(#WMYRI)
Model.Destroy(#CELLPHONE)
010D: set_player $PLAYER_CHAR wanted_level_to 2
0394: play_music 2
17@ = 5000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:KEY_N12
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y12
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO12
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN12
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random 

:Z_N13
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N13
056D:   actor 1@ defined
else_jump @Z_N13
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N13
03A3:   actor 1@ male
else_jump @Z_N13
not Actor.Driving(1@)
else_jump @Z_N13
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N13
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N13
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N13
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N13
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N13
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N13
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N13
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N13
$ONMISSION == 0 
else_jump @Z_N13
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN13
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO13
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN3' time 5000 flag 1  //Хочу насолить своему знакомому. Не поможешь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y13
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N13
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
018A: 8@ = create_checkpoint_at -1720.4371 1018.386 17.5859
08FB: set_checkpoint 8@ type_to 0
00BC: show_text_highpriority GXT 'CHDZ3' time 5000 flag 1  //Отправляйся на автомобильную стоянку.
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
Model.Load(#SUPERGT)
038B: load_requested_models
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:CAR_PARKS
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere -1776.3088 985.1026 23.5586 radius 100.0 100.0 100.0
else_jump @CAR_PARKS
Model.Available(#SUPERGT)
else_jump @FAIL_MS
Marker.Disable(8@)
14@ = Car.Create(#SUPERGT, -1720.4371, 1018.386, 17.5859)
Car.Angle(14@) = 359.1409
Marker.CreateAboveCar(15@, 14@)
Car.DoorStatus(14@) = 4
00BC: show_text_highpriority GXT 'CHDE3' time 5000 flag 1  //Проколи все шины у автомобиля с помощью огнестрельного оружия.

:END_CAR_PACKS
wait 0
if and
0496:   tire 0 on_car 14@ deflated
0496:   tire 1 on_car 14@ deflated
0496:   tire 2 on_car 14@ deflated
0496:   tire 3 on_car 14@ deflated
else_jump @END_CAR_PACK_FAILS
Marker.Disable(15@)
Car.RemoveReferences(14@)
Model.Destroy(#SUPERGT)
0394: play_music 2
17@ = 2000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:END_CAR_PACK_FAILS
if or
gosub @WASTED_OR_BUSTED
Car.Wrecked(14@)
else_jump @END_CAR_PACKS
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
00BC: show_text_highpriority GXT 'CHEF3' time 5000 flag 1 //В поручении было сказано 'проколоть шины', а не 'взорвать автомобиль'!
$ONMISSION = 0
Marker.Disable(15@)                                                                                                              
Car.RemoveReferences(14@)
Model.Destroy(#SUPERGT)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N13
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y13
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO13
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN13
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:FAIL_MS
Model.Load(#SUPERGT)
038B: load_requested_models
jump @CAR_PARKS 

:Z_N14
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N14
056D:   actor 1@ defined
else_jump @Z_N14
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N14
03A3:   actor 1@ male
else_jump @Z_N14
not Actor.Driving(1@)
else_jump @Z_N14
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N14
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N14
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N14
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N14
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N14
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N14
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N14
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N14
$ONMISSION == 0 
else_jump @Z_N14
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1 

:run_to_actorN14
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO14
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN4' time 5000 flag 1  //Эй, тут одного паренька подставить нужно, не желаешь помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y14
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N14
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
0A1D: AS_actor $PLAYER_ACTOR rotate_to_and_look_at_actor 1@
wait 500
0812: AS_actor 1@ perform_animation "ATM" IFP "PED" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time 2008  // versionB
wait 2008
00BC: show_text_highpriority GXT 'CHDZ4' time 5000 flag 1  //Заложи в автомобиль мешочек с марихуаной.
018A: 8@ = create_checkpoint_at -2226.949 304.6255 35.1172
08FB: set_checkpoint 8@ type_to 0
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
Model.Load(#CSHER)
Model.Load(#BUCCANEE)
04ED: load_animation  "ON_LOOKERS"
04ED: load_animation  "INT_HOUSE"
038B: load_requested_models
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:NEAR_CARS
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 1821.6222 -1779.0906 13.3828 radius 100.0 100.0 100.0
else_jump @NEAR_CARS
Marker.Disable(8@)
14@ = Actor.Create(CivMale, #CSHER, -2229.1287, 287.408, 35.3203)
Actor.Angle(14@) = 178.7877
0615: define_AS_pack_begin 18@
05C7: AS_actor -1 use_atm
0618: assign_actor 14@ to_AS_pack 18@
0643: set_AS_pack 18@ loop 1
15@ = Car.Create(#BUCCANEE, -2226.949, 304.6255, 35.1172)
Car.Angle(15@) = 0.5228
Car.DoorStatus(15@) = 4
04E1: open_and_freeze_car_trunk 15@
018A: 8@ = create_checkpoint_at -2226.915 301.3433 35.1172
08FB: set_checkpoint 8@ type_to 2
00BC: show_text_highpriority GXT 'CHDD3' time 5000 flag 1  //Заложи наркотики в багажник автомобиля.

:END_NC4S
wait 0
0101:   actor $PLAYER_ACTOR in_sphere -2226.915 301.3433 35.1172 radius 1.5 1.5 10.5 sphere 1.5 stopped
else_jump @END_NC4_FAILS
05D4: AS_actor $PLAYER_ACTOR rotate_angle 358.5081
wait 500
0615: define_AS_pack_begin 18@ 
0605: actor -1 perform_animation "ROADCROSS" IFP "PED" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0605: actor -1 perform_animation "wash_up" IFP "INT_HOUSE" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 18@ 
0618: assign_actor $PLAYER_ACTOR to_AS_pack 18@ 
061B: remove_references_to_AS_pack 18@
wait 5000
Car.RemoveReferences(15@)
Actor.RemoveReferences(14@)
Model.Destroy(#CSHER)
Model.Destroy(#BUCCANEE)
04EF: release_animation  "ON_LOOKERS"
04EF: release_animation  "INT_HOUSE"
0394: play_music 2
Marker.Disable(8@)
17@ = 4000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:KEY_N14
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y14
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO14
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN14
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random                

:END_NC4_FAILS
if or
Actor.Dead(14@)
Car.Wrecked(15@)
gosub @WASTED_OR_BUSTED
else_jump @END_NC4S
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
Car.RemoveReferences(15@)
Actor.RemoveReferences(14@)
Marker.Disable(8@)
Model.Destroy(#CSHER)
Model.Destroy(#BUCCANEE)
04EF: release_animation  "ON_LOOKERS"
04EF: release_animation  "INT_HOUSE"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER 

:Z_N15
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N15
056D:   actor 1@ defined
else_jump @Z_N15
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N15
03A3:   actor 1@ male
else_jump @Z_N15
not Actor.Driving(1@)
else_jump @Z_N15
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N15
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N15
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N15
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N15
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N15
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N15
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N15
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N15
$ONMISSION == 0 
else_jump @Z_N15
Marker.CreateAboveActor(27@,1@)

:run_to_actorN15
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO15
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN5' time 5000 flag 1  //Хочу испортить жизнь одному бизнесмену. Не хочешь помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y15
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N15
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CHDZ5' time 5000 flag 1  //Отправляйся на склад и подожги весь товар c помощью огнемета
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
018A: 8@ = create_checkpoint_at -1600.6219 48.2441 17.3281
08FB: set_checkpoint 8@ type_to 0
Model.Load(1224)
Model.Load(#ROCKETLA)
038B: load_requested_models
01B2: give_actor $PLAYER_ACTOR weapon 35 ammo 20
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:NEAR_CKLADS                                             
wait 0
0101:   actor $PLAYER_ACTOR in_sphere -1672.1744 3.6144 3.5547 radius 1.5 1.5 10.5 sphere 1.5 stopped 
else_jump @NEAR_CKLADS
not Actor.Driving($PLAYER_ACTOR)
else_jump @EXIT_CAR_SF
00BC: show_text_highpriority GXT 'CHZZ5' time 5000 flag 1  //Разрушь все коробки, находящиеся на складе
16@ = Object.Create(1224, -1592.2761, 56.5113, 16.3281)
17@ = Object.Create(1224, -1573.8364, 30.3027, 16.3281)
18@ = Object.Create(1224, -1556.8401, 71.954, 16.3281)
19@ = Object.Create(1224, -1537.6704, 92.6494, 16.3281)
20@ = Object.Create(1224, -1522.2765, 115.8983, 16.3281)
21@ = Object.Create(1224, -1495.6221, 139.1549, 16.3281)
22@ = Object.Create(1224, -1479.2312, 149.0643, 17.7734)
23@ = Object.Create(1224, -1535.3242, 118.0231, 16.3226)
24@ = Object.Create(1224, -1534.9883, 138.2501, 2.5547)
25@ = Object.Create(1224, -1579.1428, 137.5533, 2.7169)
26@ = 120000
27@ = 10 
0AB1: call_scm_func @SetTimer 3 VARNUMBER = 26 TYPE = 1 GXT = @StatusTextA
0AB1: call_scm_func @AddStatusText 4 VARNUMBER = 27 TYPE = 0 GXT = @StatusTextB LINE = 0
129@ = 0
130@ = 0
131@ = 0
132@ = 0
133@ = 0
134@ = 0
135@ = 0
136@ = 0
137@ = 0
138@ = 0
139@ = 0
01B9: set_actor $PLAYER_ACTOR armed_weapon_to 35
0992: set_player $PLAYER_CHAR weapons_scrollable 0

:OBJ_1SF
wait 0
if and
130@ == 0
0366: object 16@ blown_up
else_jump @OBJ_2SF
27@ -= 1
129@ += 1
130@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_2SF
if and
131@ == 0
0366: object 17@ blown_up
else_jump @OBJ_3SF
27@ -= 1
129@ += 1
131@ = 1
0663: printint "BOX_BROKE" 129@
 
:OBJ_3SF
if and
132@ == 0
0366: object 18@ blown_up
else_jump @OBJ_4SF
27@ -= 1
129@ += 1
132@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_4SF
if and
133@ == 0
0366: object 19@ blown_up
else_jump @OBJ_5SF
27@ -= 1
129@ += 1
133@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_5SF
if and
134@ == 0
0366: object 20@ blown_up
else_jump @OBJ_6SF
27@ -= 1
129@ += 1
134@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_6SF
if and
135@ == 0
0366: object 21@ blown_up
else_jump @OBJ_8SF
27@ -= 1
129@ += 1
135@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_8SF
if and
136@ == 0
0366: object 22@ blown_up
else_jump @OBJ_10SF
27@ -= 1
129@ += 1
136@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_10SF
if and
137@ == 0
0366: object 23@ blown_up
else_jump @OBJ_11SF
27@ -= 1
129@ += 1
137@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_11SF
if and
138@ == 0
0366: object 24@ blown_up
else_jump @OBJ_12SF
27@ -= 1
129@ += 1
138@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_12SF
if and
139@ == 0
0366: object 25@ blown_up
else_jump @OBJ_ENDIKLSF
27@ -= 1
129@ += 1
139@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_ENDIKLSF
129@ == 10
else_jump @OBJ_TIMERSF
0394: play_music 2
17@ = 8000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
0992: set_player $PLAYER_CHAR weapons_scrollable 1
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
0AB1: call_scm_func @RemoveStatusText 1 VARNUMBER = 27
0AB1: call_scm_func @StopTimer 1 VARNUMBER = 26
Marker.Disable(8@)
Object.RemoveReferences(16@)
Object.RemoveReferences(17@)
Object.RemoveReferences(18@)
Object.RemoveReferences(19@)
Object.RemoveReferences(20@)
Object.RemoveReferences(21@)
Object.RemoveReferences(22@)
Object.RemoveReferences(23@)
Object.RemoveReferences(24@)
Object.RemoveReferences(25@)
Model.Destroy(1224)
Model.Destroy(#ROCKETLA)
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:EXIT_CAR_SF
03E5: show_text_box 'HELPA'  // Выйдите из машины, чтобы начать задание.
wait 1000
jump @NEAR_CKLADS

:OBJ_TIMERSF
if or
gosub @WASTED_OR_BUSTED
26@ == 0
else_jump @OBJ_1SF
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
0992: set_player $PLAYER_CHAR weapons_scrollable 1
$ONMISSION = 0
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0AB1: call_scm_func @RemoveStatusText 1 VARNUMBER = 27
0AB1: call_scm_func @StopTimer 1 VARNUMBER = 26
0663: printint "TIME" 9@
Marker.Disable(8@)
Object.RemoveReferences(16@)
Object.RemoveReferences(17@)
Object.RemoveReferences(18@)
Object.RemoveReferences(19@)
Object.RemoveReferences(20@)
Object.RemoveReferences(21@)
Object.RemoveReferences(22@)
Object.RemoveReferences(23@)
Object.RemoveReferences(24@)
Object.RemoveReferences(25@)
Model.Destroy(1224)
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N15
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y15 
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
$ONMISSION = 0 
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO15
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN15
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:Z_N16
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N16
056D:   actor 1@ defined
else_jump @Z_N16
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N16
03A3:   actor 1@ male
else_jump @Z_N16
not Actor.Driving(1@)
else_jump @Z_N16
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N16
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N16
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N16
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N16
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N16
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N16
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N16
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N16
$ONMISSION == 0 
else_jump @Z_N16
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN16
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO16
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN6' time 5000 flag 1  //Нужно передать посылку одному человеку? Ты можешь помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться. 
$ONMISSION = 1                      

:KEY_Y16
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N16
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Model.Load(3052)
038B: load_requested_models
fade 0 1000 
wait 1500
Actor.StorePos($PLAYER_ACTOR, 67@, 68@, 69@)
68@ +=2.0
70@ = Object.Create(3052, 67@, 68@, 69@)
08E9: set_object 70@ liftable 1
07C9: AS_actor $PLAYER_ACTOR walk_to_object 70@ then_lift_and_hold_in_hands
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:FIDE_ENDS
wait 0
0737:   actor $PLAYER_ACTOR lifting_object 70@
else_jump @FIDE_ENDS
fade 1 1000 
wait 1000
08E9: set_object 70@ liftable 0
00BC: show_text_highpriority GXT 'CEEE6' time 5000 flag 1  //Дождитесь человека, который должен получить посылку.
0209: 17@ = random_int_in_ranges 10000 25000
wait 17@

:FIND_AS
wait 0
Actor.StorePos($PLAYER_ACTOR, 48@, 49@, 50@)
0AE1: 2@ = random_actor_near_point 48@ 49@ 50@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @FIND_AS
056D:   actor 2@ defined
else_jump @FIND_AS
089F: get_actor 2@ pedtype_to 30@
30@ == 4
else_jump @FIND_AS
03A3:   actor 2@ male
else_jump @FIND_AS
not Actor.Driving(2@)
else_jump @FIND_AS

:WALKS
Actor.StorePos($PLAYER_ACTOR, 71@, 72@, 73@) 
07CD: AS_actor 2@ walk_to 71@ 72@ 73@ stop_with_angle 270.0 within_radius 4.0

:POSLKA_ENDS
wait 0
0105:   actor 2@ near_actor $PLAYER_ACTOR radius 2.0 2.0 2.0 sphere 0 on_foot
else_jump @WALKS
Object.Destroy(70@)
Model.Destroy(3052)
0687: clear_actor $PLAYER_ACTOR task
0394: play_music 2
17@ = 1500
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
Actor.RemoveReferences(40@)
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER 

:KEY_N16
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y16 
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO16
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN16
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random 

:Z_N17
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N17
056D:   actor 1@ defined
else_jump @Z_N17
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N17
03A3:   actor 1@ male
else_jump @Z_N17
not Actor.Driving(1@)
else_jump @Z_N17
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N17
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N17
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N17
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N17
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N17
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N17
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N17
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N17
$ONMISSION == 0 
else_jump @Z_N17
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN17
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO17
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN7' time 5000 flag 1  //Я работаю курьером, мне нужно передать цветы одной девушки, но я не успеваю! Вы можете мне помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1                       

:KEY_Y17
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N17
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CDZ17' time 5000 flag 1  //Отправляйся к Мэрии Сан Фиерро. //!!!!!
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
018A: 8@ = create_checkpoint_at -2701.2207 376.1625 4.9716
08FB: set_checkpoint 8@ type_to 0
Model.Load(#flowera)
04ED: load_animation  "KISSING"
038B: load_requested_models
01B2: give_actor $PLAYER_ACTOR weapon 14 ammo 1 // Load the weapon model before using this
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:NEAR_FLOWERSS
wait 0
0101:   actor $PLAYER_ACTOR in_sphere -2701.2207 376.1625 4.9716 radius 1.5 1.5 10.5 sphere 1.5 stopped
else_jump @NEAR_FLOWERSS

:DRIVE2
Actor.Driving($PLAYER_ACTOR)
else_jump @NEAR_FLOWERSS
00BC: show_text_highpriority GXT 'EEE7' time 1000 flag 1  //Стой здесь, пока не появится девушка, которой нужно отдать цветы. 
Actor.StorePos($PLAYER_ACTOR, 2@, 3@, 4@)
0AE1: 1@ = random_actor_near_point 2@ 3@ 4@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @NEAR_FLOWERSS
056D:   actor 1@ defined
else_jump @NEAR_FLOWERSS
089F: get_actor 1@ pedtype_to 30@
30@ == 5
else_jump @NEAR_FLOWERSS
not Actor.Driving(1@)
else_jump @NEAR_FLOWERSS
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @NEAR_FLOWERSS
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @NEAR_FLOWERSS
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @NEAR_FLOWERSS
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @NEAR_FLOWERSS
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @NEAR_FLOWERSS
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @NEAR_FLOWERSS
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @NEAR_FLOWERSS
Marker.CreateAboveActor(27@,1@)
Marker.SetColor(27@, 1)
00BC: show_text_highpriority GXT 'CHDE7' time 5000 flag 1  //Передай девушке цветы.
Marker.Disable(8@)


:FLOWERS_ENDS
wait 0
0105:   actor $PLAYER_ACTOR near_actor 1@ radius 2.0 2.0 2.0 sphere 0 on_foot
else_jump @FLOWERS_END_FAILS
0687: clear_actor $PLAYER_ACTOR task
0687: clear_actor 1@ task
0992: set_player $PLAYER_CHAR weapons_scrollable 0
01B9: set_actor $PLAYER_ACTOR armed_weapon_to 14
0639: AS_actor 1@ rotate_to_actor $PLAYER_ACTOR
0639: AS_actor $PLAYER_ACTOR rotate_to_actor 1@  
0605: actor $PLAYER_ACTOR perform_animation "gift_give" IFP "KISSING" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 5330
0605: actor 1@ perform_animation "gift_get" IFP "KISSING" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 5330  
04EF: release_animation "KISSING"
wait 5000
0992: set_player $PLAYER_CHAR weapons_scrollable 1
01B2: give_actor 1@ weapon 14 ammo 1 // Load the weapon model before using this
01B9: set_actor 1@ armed_weapon_to 14
0555: remove_weapon 14 from_actor $PLAYER_ACTOR
0394: play_music 2
17@ = 1000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:FLOWERS_END_FAILS
if or
856D:  not actor 1@ defined
Actor.Dead(1@)
8491:  not actor $PLAYER_ACTOR has_weapon 14
gosub @WASTED_OR_BUSTED
else_jump @FLOWERS_ENDS
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
Marker.Disable(27@)
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N17
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y17 
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO17
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN17
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random  

:Z_N18
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N18
056D:   actor 1@ defined
else_jump @Z_N18
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N18
03A3:   actor 1@ male
else_jump @Z_N18
not Actor.Driving(1@)
else_jump @Z_N18
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N18
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N18
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N18
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N18
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N18
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N18
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N18
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N18
$ONMISSION == 0 
else_jump @Z_N18
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN18
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO18
05C1: AS_actor 1@ speak_from_audio_table 166
Actor.StorePos(1@, 90@, 91@, 92@)
0665: get_actor 1@ model_to 93@
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN9' time 5000 flag 1  //Мне кажется, моя девушка мне изменяет. Ты можешь помочь мне выявить её ухажера?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1                       

:KEY_Y18
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N18
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CDZ19' time 5000 flag 1  //Отправляйся на пирс 69. //!!!!!
Model.Load(233)
Model.Load(185)
038B: load_requested_models
018A: 8@ = create_checkpoint_at -1704.1309 1339.6395 7.1814
08FB: set_checkpoint 8@ type_to 0
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
Model.Load(233)
Model.Load(185)
Model.Load(#CAMERA)
04ED: load_animation  "KISSING"
038B: load_requested_models
01B2: give_actor $PLAYER_ACTOR weapon 43 ammo 999999 // Load the weapon model before using this
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:NEAR_PRS
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere -1704.1309 1339.6395 7.1814 radius 100.0 100.0 100.0
else_jump @NEAR_PRS
Marker.Disable(8@)
2@ = Actor.Create(4, 185, -1630.84, 1414.8379, 7.1875)
3@ = Actor.Create(5, 233, -1631.5889, 1415.3711, 7.1875)
Actor.Angle(2@) = 38.7055
Actor.Angle(3@) = 222.1031
wait 500
0615: define_AS_pack_begin 18@
0605: actor -1 perform_animation "Grlfrd_Kiss_02" IFP "KISSING" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1
0618: assign_actor 3@ to_AS_pack 18@
0643: set_AS_pack 18@ loop 1
//*************************//
Marker.CreateAboveActor(97@, 2@)
Marker.CreateAboveActor(98@, 3@)
00BC: show_text_highpriority GXT 'CHDE9' time 5000 flag 1  //Сфотографируй измену. Не подходи к ним слишком близко.

:PHOTOS
wait 0
if and
04C5:   actor 2@ photographed
04C5:   actor 3@ photographed
else_jump @PHOTO_FAILS
Marker.Disable(97@)
Marker.Disable(98@)                                                            
00BC: show_text_highpriority GXT 'CEDE9' time 5000 flag 1  //Передай фотографию человеку.
018A: 8@ = create_checkpoint_at 90@ 91@ 92@
08FB: set_checkpoint 8@ type_to 0
Model.Load(93@)
038B: load_requested_models
jump @PHOTO_END1

:PHOTO_END1S
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 90@ 91@ 92@ radius 100.0 100.0 100.0
else_jump @PHOTO_END1S
1@ = Actor.Create(CivMale, 93@, 90@, 91@, 92@)
jump @PHOTO_END2S

:PHOTO_FAILS
if or
00F2:   actor $PLAYER_ACTOR near_actor 2@ radius 20.0 20.0 sphere 0
00F2:   actor $PLAYER_ACTOR near_actor 3@ radius 20.0 20.0 sphere 0
gosub @WASTED_OR_BUSTED
else_jump @PHOTOS
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
0616: define_AS_pack_end 18@
0616: define_AS_pack_end 19@
061B: remove_references_to_AS_pack 18@ 
061B: remove_references_to_AS_pack 19@
Marker.Disable(97@)
Marker.Disable(98@)
Actor.RemoveReferences(2@)
Actor.RemoveReferences(3@) 
Marker.Disable(8@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:PHOTO_END2S
wait 0
0105:   actor $PLAYER_ACTOR near_actor 1@ radius 2.0 2.0 2.0 sphere 0 on_foot
else_jump @PHOTO_END2_FAILS
Marker.Disable(8@)
0687: clear_actor $PLAYER_ACTOR task
0687: clear_actor 1@ task
0639: AS_actor 1@ rotate_to_actor $PLAYER_ACTOR
0639: AS_actor $PLAYER_ACTOR rotate_to_actor 1@  
0605: actor $PLAYER_ACTOR perform_animation "ATM" IFP "PED" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 2008  
wait 2008
0394: play_music 2
17@ = 5000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
Marker.Disable(94@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:PHOTO_END2_FAILS
if or
856D:  not actor 1@ defined
Actor.Dead(1@)
8491:  not actor $PLAYER_ACTOR has_weapon 14
gosub @WASTED_OR_BUSTED
else_jump @PHOTO_END2S
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
Marker.Disable(27@)
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N18
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y18 
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO18
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN18
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:Z_N19
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N19
056D:   actor 1@ defined
else_jump @Z_N19
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N19
03A3:   actor 1@ male
else_jump @Z_N19
not Actor.Driving(1@)
else_jump @Z_N19
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N19
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N19
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N19
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N19
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N19
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N19
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N19
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N19
$ONMISSION == 0 
else_jump @Z_N19
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN19
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO19
05C1: AS_actor 1@ speak_from_audio_table 166
0665: get_actor 1@ model_to 93@
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CDN10' time 5000 flag 1  //Нужно украсть одну вещь из дома, ты можешь помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1                       

:KEY_Y19
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N19
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CZ19' time 5000 flag 1  //Ограбь дом в районе Парадизо. //!!!!!
0A40: 2@ = create_entrance_marker_at -2840.2219 884.5217 44.0547 color 14
018A: 8@ = create_checkpoint_at -2840.2219 884.5217 44.0547
08FB: set_checkpoint 8@ type_to 0
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:ENTERS
wait 0
00ED:   actor $PLAYER_ACTOR sphere 0 near_point -2840.2219 884.5217 radius 2.0 2.0 on_foot
else_jump @ENTERS
Marker.Disable(8@)
0A41: destroy_entrance_marker 2@
fade 0 1000 
wait 1500
select_interior 2
0860: link_actor $PLAYER_ACTOR to_interior 2
Actor.PutAt($PLAYER_ACTOR, 224.7515, 1240.0166, 1082.1406)
3@ = Pickup.Create(1581, 3, 224.871, 1253.1106, 1082.1406)
03DC: 4@ = create_marker_above_pickup 3@
Marker.SetColor(4@, 1)
fade 1 1000 
wait 1000
00BC: show_text_highpriority GXT 'CDZ10' time 5000 flag 1  //Подбери вещь, которая нужна человеку.
08E7: disable_entrance_markers 1

:PIK_UPS
wait 0
Pickup.Picked_up(3@)
else_jump @PIK_UPS
0A40: 2@ = create_entrance_marker_at 2066.9763 -1656.5579 15.075 color 14
018A: 8@ = create_checkpoint_at 2066.9763 -1656.5579 14.075
08FB: set_checkpoint 8@ type_to 0
00BC: show_text_highpriority GXT 'CDE10' time 5000 flag 1  //Направляйся к выходу
Model.Load(93@)
038B: load_requested_models

:EXITS
wait 0
00ED:   actor $PLAYER_ACTOR sphere 0 near_point 226.6236 1240.0719 radius 2.0 2.0 on_foot
else_jump @EXITS
Marker.Disable(8@)
0A41: destroy_entrance_marker 2@
fade 0 1000 
wait 1500
select_interior 0
0860: link_actor $PLAYER_ACTOR to_interior 0
Actor.PutAt($PLAYER_ACTOR, -2838.7554, 884.0189, 44.0547)
1@ = Actor.Create(CivMale, 93@, -2837.1177, 884.3268, 44.0547)
Actor.Angle(1@) = 92.4839
fade 1 1000 
wait 1000
0687: clear_actor $PLAYER_ACTOR task
0687: clear_actor 1@ task
0639: AS_actor 1@ rotate_to_actor $PLAYER_ACTOR
0639: AS_actor $PLAYER_ACTOR rotate_to_actor 1@  
0605: actor $PLAYER_ACTOR perform_animation "ATM" IFP "PED" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 2008  
wait 2008
0394: play_music 2
17@ = 10000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0 
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
Marker.Disable(94@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:KEY_N19
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y19 
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO19
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN19
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:Z_N20
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N20
056D:   actor 1@ defined
else_jump @Z_N20
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N20
03A3:   actor 1@ male
else_jump @Z_N20
not Actor.Driving(1@)
else_jump @Z_N20
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N20
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N20
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N20
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N20
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N20
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N20
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N20
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N20
$ONMISSION == 0 
else_jump @Z_N20
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN20
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO20
05C1: AS_actor 1@ speak_from_audio_table 166
0665: get_actor 1@ model_to 93@
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CZN20' time 5000 flag 1  //Сейчас на площади Сан Фиерро идет выбор нового мэра, ты можешь сорвать эти выборы?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1                       

:KEY_Y20
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N20
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CHZ20' time 5000 flag 1  //Сорви выборы на площади Сан Фиерро.
018A: 88@ = create_checkpoint_at -2699.0461 375.8442 4.3767
08FB: set_checkpoint 88@ type_to 0
Model.Load(#SWMYRI)
Model.Load(#MALE01)
Model.Load(#BFYRI)
Model.Load(#BMORI)
Model.Load(#BFYST)
Model.Load(#HFORI)
Model.Load(#WBDYG2)
Model.Load(#WMYCON)
Model.Load(#HMORI)
Model.Load(#OFYST)
Model.Load(#WFYSTEW)
Model.Load(#BMYBOUN)
Model.Load(#WMYBOUN)
038B: load_requested_models
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"


:NEAR_SQS
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere -2699.0461 375.8442 4.3767 radius 100.0 100.0 100.0
else_jump @NEAR_SQS
0@ = Actor.Create(4, #SWMYRI, -2701.5513, 376.352, 4.9717)//0
1@ = Actor.Create(4, #MALE01, -2697.8723, 377.9319, 4.3697)
2@ = Actor.Create(5, #BFYRI, -2698.0688, 376.2413, 4.3748)
3@ = Actor.Create(4, #BMORI, -2697.8674, 374.83, 4.3788)
4@ = Actor.Create(5, #BFYST, -2698.0688, 373.2619, 4.3824)
5@ = Actor.Create(5, #HFORI, -2699.4797, 371.6577, 4.3873)
6@ = Actor.Create(4, #WBDYG2, -2699.4441, 373.433, 4.383)
7@ = Actor.Create(4, #WMYCON, -2699.354, 374.8383, 4.3798)
8@ = Actor.Create(4, #HMORI, -2699.4915, 376.1718, 4.376)
9@ = Actor.Create(5, #OFYST, -2699.6611, 377.8256, 4.3713)
10@ = Actor.Create(5, #WFYSTEW, -2699.4075, 379.4515, 4.375) 
11@ = Actor.Create(4, #BMYBOUN, -2700.4041, 377.9484, 4.6978)//1
12@ = Actor.Create(4, #WMYBOUN, -2700.2869, 373.6995, 4.6565)//2
Actor.Angle(0@) = 272.8167
Actor.Angle(1@) = 66.3785
Actor.Angle(2@) = 68.2585
Actor.Angle(3@) = 68.5719
Actor.Angle(4@) = 90.1921
Actor.Angle(5@) = 90.8187
Actor.Angle(6@) = 122.1524
Actor.Angle(7@) = 123.0924
Actor.Angle(8@) = 124.0324
Actor.Angle(9@) = 94.5788
Actor.Angle(10@) = 94.5788
Actor.Angle(11@) = 259.0533
Actor.Angle(12@) = 270.6468
//
0615: define_AS_pack_begin 18@
0605: actor -1 perform_animation "IDLE_CHAT" IFP "PED" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1
0618: assign_actor 0@ to_AS_pack 18@
0643: set_AS_pack 18@ loop 1
//
00BC: show_text_highpriority GXT 'CHE10' time 5000 flag 1  //Спровоцируй драку в толпе, ударив любого находящегося на площади человека.

:DAMAGES
wait 0
if or
gosub @DAMAGE_A
gosub @DAMAGE_B
else_jump @DAMAGE_FAILS
not Actor.Driving($PLAYER_ACTOR)
else_jump @DAMAGE_FAILS
00BC: show_text_highpriority GXT 'CHX10' time 3000 flag 1  //(Голос из толпы): Эй, кто меня ударил?
wait 3000
00BC: show_text_highpriority GXT 'CHX11' time 5000 flag 1  //(Голос из толпы): Ты это мне?!
wait 1000
05E2: AS_actor 1@ kill_actor 2@
05E2: AS_actor 2@ kill_actor 1@
05E2: AS_actor 3@ kill_actor 4@
05E2: AS_actor 4@ kill_actor 3@
05E2: AS_actor 5@ kill_actor 6@
05E2: AS_actor 6@ kill_actor 7@
05E2: AS_actor 7@ kill_actor 8@
05E2: AS_actor 8@ kill_actor 7@
05E2: AS_actor 9@ kill_actor 10@
05E2: AS_actor 10@ kill_actor 9@
05E2: AS_actor 11@ kill_actor 6@
05E2: AS_actor 12@ kill_actor 5@
05C3: AS_actor 0@ hands_cower
Marker.Disable(88@)
0394: play_music 2
Actor.StorePos($PLAYER_ACTOR, 55@, 66@, 77@)
17@ = 15000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @DESTROYS

:DAMAGE_FAILS
if or
051A:   actor 0@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 11@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 12@ damaged_by_actor $PLAYER_ACTOR
gosub @WASTED_OR_BUSTED
else_jump @DAMAGE_GCARS
Marker.Disable(88@)
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @DESTROYS

:DAMAGE_GCARS
Actor.Driving($PLAYER_ACTOR)
else_jump @DAMAGES
99@ = Actor.CurrentCar($PLAYER_ACTOR)
if or
gosub @DAMAGE_C
gosub @DAMAGE_D
else_jump @DAMAGES
Marker.Disable(88@)
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @DESTROYS

:DESTROYS
wait 0
80FE:  not actor $PLAYER_ACTOR sphere 0 in_sphere 55@ 66@ 77@ radius 100.0 100.0 100.0
else_jump @DESTROYS
Actor.RemoveReferences(0@)
Actor.RemoveReferences(1@)
Actor.RemoveReferences(2@)
Actor.RemoveReferences(3@)
Actor.RemoveReferences(4@)
Actor.RemoveReferences(5@)
Actor.RemoveReferences(6@)
Actor.RemoveReferences(7@)
Actor.RemoveReferences(8@)
Actor.RemoveReferences(9@)
Actor.RemoveReferences(10@)
Actor.RemoveReferences(11@)
Actor.RemoveReferences(12@)
Model.Destroy(#SWMYRI)
Model.Destroy(#MALE01)
Model.Destroy(#BFYRI)
Model.Destroy(#BMORI)
Model.Destroy(#BFYST)
Model.Destroy(#HFORI)
Model.Destroy(#WBDYG2)
Model.Destroy(#WMYCON)
Model.Destroy(#HMORI)
Model.Destroy(#OFYST)
Model.Destroy(#WFYSTEW)
Model.Destroy(#BMYBOUN)
Model.Destroy(#WMYBOUN)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
jump @TIMER

:KEY_N20
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y20 
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
$ONMISSION = 0 
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO20
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN20
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:Z_N21
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N21
056D:   actor 1@ defined
else_jump @Z_N21
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N21
03A3:   actor 1@ male
else_jump @Z_N21
not Actor.Driving(1@)
else_jump @Z_N21
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N21
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N21
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N21
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N21
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N21
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N21
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N21
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N21
$ONMISSION == 0 
else_jump @Z_N21
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN21
wait 0
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @run_to_actorN21_NO
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CDN11' time 5000 flag 1  //Чувак, мне нужно угнать автомобиль для участия в гонках. Не поможешь? //!!!!!
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y21
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N21
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CDZ21' time 5000 flag 1  //Найди и угони автомобиль марки Turismo. //!!!!!
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:GCARL
wait 0
00DD:   actor $PLAYER_ACTOR driving_car_with_model #TURISMO
else_jump @GCARL
7@ = Actor.CurrentCar($PLAYER_ACTOR)
00BC: show_text_highpriority GXT 'CHDE1' time 5000 flag 1  //Отвези автомобиль в гараж заказчика
018A: 8@ = create_checkpoint_at 1710.3878 1807.2006 10.8203
08FB: set_checkpoint 8@ type_to 0

:END_Z21
wait 0
0101:   actor $PLAYER_ACTOR in_sphere 1710.3878 1807.2006 10.8203 radius 1.5 1.5 10.5 sphere 1.5 stopped 
else_jump @END_Z21
Actor.InCar($PLAYER_ACTOR, 7@)
else_jump @END_Z21_F
fade 0 1000 
wait 1500
0633: AS_actor $PLAYER_ACTOR exit_car
wait 2000
Actor.PutAt($PLAYER_ACTOR, 1711.1808, 1797.8025, 9.8203)
Actor.Angle($PLAYER_ACTOR) = 182.1706
Camera.Restore()
Camera.SetBehindPlayer()
Car.Destroy(7@)
fade 1 1000 
wait 1000
0394: play_music 2
17@ = 3000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
0632: release_group $PLAYER_GROUP
Car.RemoveReferences(7@)
Marker.Disable(8@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:END_Z21_F
if or
gosub @WASTED_OR_BUSTED
Car.Wrecked(7@)
else_jump @END_Z21
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
0632: release_group $PLAYER_GROUP
Car.RemoveReferences(7@)
Marker.Disable(8@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N21
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y21
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1 // Вы отказались от поручения!
$ONMISSION = 0
05DE: AS_actor 1@ walk_around_ped_path
Marker.Disable(27@)
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorN21_NO
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN21
Marker.Disable(27@)
jump @random

:Z_N22
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N22
056D:   actor 1@ defined
else_jump @Z_N22
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N22
03A3:   actor 1@ male
else_jump @Z_N22
not Actor.Driving(1@)
else_jump @Z_N22
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N22
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N22
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N22
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N22
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N22
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N22
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N22
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N22
$ONMISSION == 0 
else_jump @Z_N22 //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
Marker.CreateAboveActor(27@,1@)

:run_to_actorN22
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO22
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN2' time 5000 flag 1  //Эй, парень, мне нужно убить одного человека, он слишком много знает.
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y22
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N22
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CHDZ2' time 5000 flag 1  //Отправляйся к зданию суда и убей свидетеля.
018A: 8@ = create_checkpoint_at 998.7443 1708.9592 10.9219
08FB: set_checkpoint 8@ type_to 0
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
Model.Load(#WMYRI)
Model.Load(#CELLPHONE)
038B: load_requested_models
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:CACTL
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 998.7443 1708.9592 10.9219 radius 100.0 100.0 100.0
else_jump @CACTL
Marker.Disable(8@)
12@ = Actor.Create(CivMale, #WMYRI, 941.7604, 1730.7496, 8.8516)
Actor.Angle(12@) = 271.3219
0729: AS_actor 12@ hold_cellphone 1
Marker.CreateAboveActor(13@, 12@)
00BC: show_text_highpriority GXT 'CHDE2' time 5000 flag 1  //Убей свидетеля и скройся с места преступления.

:BEG_GUNL
wait 0
00F2:   actor $PLAYER_ACTOR near_actor 12@ radius 6.0 6.0 sphere 0
else_jump @END_CACTL
0470: 76@ = actor $PLAYER_ACTOR current_weapon
if or
76@ == 0
76@ == 1
76@ == 2
76@ == 3
76@ == 6
76@ == 7
else_jump @FAIL_COPSL
jump @END_CACTL

:FAIL_COPSL
0729: AS_actor 12@ hold_cellphone 0
00BC: show_text_highpriority GXT 'CHEE2' time 5000 flag 1  //Помогите, у этого человека в руках оружие!
05DA: AS_actor 12@ run_away_in_panic_from 998.7443 1708.9592 10.9219 away_radius 100.0 timelimit 999999

:COP_FINDL
Actor.StorePos(12@, 78@, 79@, 80@)
0AE1: 77@ = random_actor_near_point 78@ 79@ 80@ in_radius 15.0 find_next 1 pass_deads 1
056D:   actor 77@ defined
else_jump @GUN_DIEL
089F: get_actor 77@ pedtype_to 81@
81@ == 6
else_jump @GUN_DIEL
010D: set_player $PLAYER_CHAR wanted_level_to 2
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
00BC: show_text_highpriority GXT 'CHEF2' time 5000 flag 1 //Вас заметили полицейские!
$ONMISSION = 0
Marker.Disable(13@)
Model.Destroy(#WMYRI)
Model.Destroy(#CELLPHONE)
wait 5000
Actor.RemoveReferences(12@)
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:END_CACTL
Actor.Dead(12@)
else_jump @BEG_GUNL
Marker.Disable(13@)
Actor.RemoveReferences(12@)
Model.Destroy(#WMYRI)
Model.Destroy(#CELLPHONE)
010D: set_player $PLAYER_CHAR wanted_level_to 2
0394: play_music 2
17@ = 5000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:GUN_DIEL
wait 0
Actor.Dead(12@)
else_jump @GUN_DIEL
Marker.Disable(13@)
Actor.RemoveReferences(12@)
Model.Destroy(#WMYRI)
Model.Destroy(#CELLPHONE)
010D: set_player $PLAYER_CHAR wanted_level_to 2
0394: play_music 2
17@ = 5000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:KEY_N22
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y22
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO22
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN22
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:Z_N23
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N23
056D:   actor 1@ defined
else_jump @Z_N23
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N23
03A3:   actor 1@ male
else_jump @Z_N23
not Actor.Driving(1@)
else_jump @Z_N23
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N23
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N23
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N23
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N23
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N23
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N23
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N23
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N23
$ONMISSION == 0 
else_jump @Z_N23
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN23
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO23
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN3' time 5000 flag 1  //Хочу насолить своему знакомому. Не поможешь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y23
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N23
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
018A: 8@ = create_checkpoint_at 1728.9263 1305.1613 10.8178
08FB: set_checkpoint 8@ type_to 0
00BC: show_text_highpriority GXT 'CHDZ3' time 5000 flag 1  //Отправляйся на автомобильную стоянку.
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
Model.Load(#SUPERGT)
038B: load_requested_models
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:CAR_PARKL
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 1728.9263 1305.1613 10.8178 radius 100.0 100.0 100.0
else_jump @CAR_PARKL
Model.Available(#SUPERGT)
else_jump @FAIL_ML
Marker.Disable(8@)
14@ = Car.Create(#SUPERGT, 1644.0813, 1316.0076, 10.8203)
Car.Angle(14@) = 1.6191
Marker.CreateAboveCar(15@, 14@)
Car.DoorStatus(14@) = 4
00BC: show_text_highpriority GXT 'CHDE3' time 5000 flag 1  //Проколи все шины у автомобиля с помощью огнестрельного оружия.

:END_CAR_PACKL
wait 0
if and
0496:   tire 0 on_car 14@ deflated
0496:   tire 1 on_car 14@ deflated
0496:   tire 2 on_car 14@ deflated
0496:   tire 3 on_car 14@ deflated
else_jump @END_CAR_PACK_FAILL
Marker.Disable(15@)
Car.RemoveReferences(14@)
Model.Destroy(#SUPERGT)
0394: play_music 2
17@ = 2000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:END_CAR_PACK_FAILL
if or
Car.Wrecked(14@)
gosub @WASTED_OR_BUSTED
else_jump @END_CAR_PACKL
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
Marker.Disable(15@)                                                                                                              
Car.RemoveReferences(14@)
Model.Destroy(#SUPERGT)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N23
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y23
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO23
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN23
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:FAIL_ML
Model.Load(#SUPERGT)
038B: load_requested_models
jump @CAR_PARKL

:Z_N24
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N24
056D:   actor 1@ defined
else_jump @Z_N24
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N24
03A3:   actor 1@ male
else_jump @Z_N24
not Actor.Driving(1@)
else_jump @Z_N24
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N24
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N24
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N24
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N24
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N24
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N24
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N24
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N24
$ONMISSION == 0 
else_jump @Z_N24
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1 

:run_to_actorN24
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO24
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN4' time 5000 flag 1  //Эй, тут одного паренька подставить нужно, не желаешь помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1

:KEY_Y24
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N24
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
0A1D: AS_actor $PLAYER_ACTOR rotate_to_and_look_at_actor 1@
wait 500
0812: AS_actor 1@ perform_animation "ATM" IFP "PED" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time 2008  // versionB
wait 2008
00BC: show_text_highpriority GXT 'CHDZ4' time 5000 flag 1  //Заложи в автомобиль мешочек с марихуаной.
018A: 8@ = create_checkpoint_at 2100.6792 2072.9446 10.8203
08FB: set_checkpoint 8@ type_to 0
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
Model.Load(#CSHER)
Model.Load(#BUCCANEE)
04ED: load_animation  "ON_LOOKERS"
04ED: load_animation  "INT_HOUSE"
038B: load_requested_models
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:NEAR_CARL
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 2136.4851 2035.4517 10.8782 radius 100.0 100.0 100.0
else_jump @NEAR_CARL
Marker.Disable(8@)
14@ = Actor.Create(CivMale, #CSHER, 2086.8062, 2071.2178, 11.0579)
Actor.Angle(14@) = 80.9721
0615: define_AS_pack_begin 18@
05C7: AS_actor -1 use_atm
0618: assign_actor 14@ to_AS_pack 18@
0643: set_AS_pack 18@ loop 1
15@ = Car.Create(#BUCCANEE, 2103.9419, 2072.6377, 10.8203)
Car.Angle(15@) = 264.3954
Car.DoorStatus(15@) = 4
04E1: open_and_freeze_car_trunk 15@
018A: 8@ = create_checkpoint_at 2100.6792 2072.9446 10.8203
08FB: set_checkpoint 8@ type_to 0
00BC: show_text_highpriority GXT 'CHDD3' time 5000 flag 1  //Заложи наркотики в багажник автомобиля.

:END_NC4L
wait 0
0101:   actor $PLAYER_ACTOR in_sphere 2100.6792 2072.9446 10.8203 radius 1.5 1.5 10.5 sphere 1.5 stopped
else_jump @END_NC4_FAILL
05D4: AS_actor $PLAYER_ACTOR rotate_angle 265.6351
wait 500
0615: define_AS_pack_begin 18@ 
0605: actor -1 perform_animation "ROADCROSS" IFP "PED" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0605: actor -1 perform_animation "wash_up" IFP "INT_HOUSE" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 18@ 
0618: assign_actor $PLAYER_ACTOR to_AS_pack 18@ 
061B: remove_references_to_AS_pack 18@
wait 5000
Car.RemoveReferences(15@)
Actor.RemoveReferences(14@)
Model.Destroy(#CSHER)
Model.Destroy(#BUCCANEE)
04EF: release_animation  "ON_LOOKERS"
04EF: release_animation  "INT_HOUSE"
0394: play_music 2
Marker.Disable(8@)
17@ = 4000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:KEY_N24
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y24
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO24
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN24
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random                

:END_NC4_FAILL
if or
Actor.Dead(14@)
Car.Wrecked(15@)
gosub @WASTED_OR_BUSTED
else_jump @END_NC4L
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
Marker.Disable(8@)
Car.RemoveReferences(15@)
Actor.RemoveReferences(14@)
Model.Destroy(#CSHER)
Model.Destroy(#BUCCANEE)
04EF: release_animation  "ON_LOOKERS"
04EF: release_animation  "INT_HOUSE"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:Z_N25
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N25
056D:   actor 1@ defined
else_jump @Z_N25
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N25
03A3:   actor 1@ male
else_jump @Z_N25
not Actor.Driving(1@)
else_jump @Z_N25
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N25
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N25
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N25
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N25
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N25
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N25
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N25
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N25
$ONMISSION == 0 
else_jump @Z_N25
Marker.CreateAboveActor(27@,1@)

:run_to_actorN25
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO25
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN5' time 5000 flag 1  //Хочу испортить жизнь одному бизнесмену. Не хочешь помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1
                                                          
:KEY_Y25
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N25
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CHDZ5' time 5000 flag 1  //Отправляйся на склад и подожги весь товар c помощью огнемета
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
018A: 8@ = create_checkpoint_at 1667.3287 994.1517 10.8203
08FB: set_checkpoint 8@ type_to 0
Model.Load(1224)
Model.Load(#ROCKETLA)
038B: load_requested_models
01B2: give_actor $PLAYER_ACTOR weapon 35 ammo 20
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:NEAR_CKLADL                                             
wait 0
0101:   actor $PLAYER_ACTOR in_sphere 1667.3287 994.1517 10.8203 radius 1.5 1.5 10.5 sphere 1.5 stopped 
else_jump @NEAR_CKLADL
not Actor.Driving($PLAYER_ACTOR)
else_jump @EXIT_CAR_LV
00BC: show_text_highpriority GXT 'CHZZ5' time 5000 flag 1
16@ = Object.Create(1224, 1595.1163, 1072.8943, 9.7938)
17@ = Object.Create(1224, 1600.6777, 1073.5302, 9.8203)
18@ = Object.Create(1224, 1652.8779, 1079.9467, 9.8203)
19@ = Object.Create(1224, 1663.2775, 1113.2296, 9.7245)
20@ = Object.Create(1224, 1671.2206, 1059.9396, 10.1765)
21@ = Object.Create(1224, 1726.0592, 1050.9537, 9.8203)
22@ = Object.Create(1224, 1706.145, 1002.7928, 9.8203)
23@ = Object.Create(1224, 1726.5825, 986.9708, 9.8203)
24@ = Object.Create(1224, 1735.7356, 968.6512, 9.8203)
25@ = Object.Create(1224, 1735.8656, 893.2555, 9.7315)
26@ = 180000
27@ = 10 
0AB1: call_scm_func @SetTimer 3 VARNUMBER = 26 TYPE = 1 GXT = @StatusTextA
0AB1: call_scm_func @AddStatusText 4 VARNUMBER = 27 TYPE = 0 GXT = @StatusTextB LINE = 0
130@ = 0
131@ = 0
132@ = 0
133@ = 0
134@ = 0
135@ = 0
136@ = 0
137@ = 0
138@ = 0
139@ = 0
01B9: set_actor $PLAYER_ACTOR armed_weapon_to 35
0992: set_player $PLAYER_CHAR weapons_scrollable 0

:OBJ_1
wait 0
if and
130@ == 0
0366: object 16@ blown_up
else_jump @OBJ_2
27@ -= 1
129@ += 1
130@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_2
if and
131@ == 0
0366: object 17@ blown_up
else_jump @OBJ_3
27@ -= 1
129@ += 1
131@ = 1
0663: printint "BOX_BROKE" 129@
 
:OBJ_3
if and
132@ == 0
0366: object 18@ blown_up
else_jump @OBJ_4
27@ -= 1
129@ += 1
132@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_4
if and
133@ == 0
0366: object 19@ blown_up
else_jump @OBJ_5
27@ -= 1
129@ += 1
133@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_5
if and
134@ == 0
0366: object 20@ blown_up
else_jump @OBJ_6
27@ -= 1
129@ += 1
134@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_6
if and
135@ == 0
0366: object 21@ blown_up
else_jump @OBJ_8
27@ -= 1
129@ += 1
135@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_8
if and
136@ == 0
0366: object 22@ blown_up
else_jump @OBJ_10
27@ -= 1
129@ += 1
136@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_10
if and
137@ == 0
0366: object 23@ blown_up
else_jump @OBJ_11
27@ -= 1
129@ += 1
137@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_11
if and
138@ == 0
0366: object 24@ blown_up
else_jump @OBJ_12
27@ -= 1
129@ += 1
138@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_12
if and
139@ == 0
0366: object 25@ blown_up
else_jump @OBJ_ENDIKL
27@ -= 1
129@ += 1
139@ = 1
0663: printint "BOX_BROKE" 129@

:OBJ_ENDIKL
129@ == 10
else_jump @OBJ_TIMER
0394: play_music 2
17@ = 8000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
0992: set_player $PLAYER_CHAR weapons_scrollable 1
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
014F: stop_timer $AF2KAKA
0AB1: call_scm_func @RemoveStatusText 1 VARNUMBER = 27
0AB1: call_scm_func @StopTimer 1 VARNUMBER = 26
Marker.Disable(8@)
Object.RemoveReferences(16@)
Object.RemoveReferences(17@)
Object.RemoveReferences(18@)
Object.RemoveReferences(19@)
Object.RemoveReferences(20@)
Object.RemoveReferences(21@)
Object.RemoveReferences(22@)
Object.RemoveReferences(23@)
Object.RemoveReferences(24@)
Object.RemoveReferences(25@)
Model.Destroy(1224)
Model.Destroy(#ROCKETLA)
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:EXIT_CAR_LV
03E5: show_text_box 'HELPA'  // Выйдите из машины, чтобы начать задание.
wait 1000
jump @NEAR_CKLADL 

:KEY_N25
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y25
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136 
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
$ONMISSION = 0 
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO25
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN25
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:OBJ_TIMER
if or
26@ == 0
gosub @WASTED_OR_BUSTED
else_jump @OBJ_1
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
0992: set_player $PLAYER_CHAR weapons_scrollable 1
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0AB1: call_scm_func @RemoveStatusText 1 VARNUMBER = 27
0AB1: call_scm_func @StopTimer 1 VARNUMBER = 26
0663: printint "TIME" 9@
Marker.Disable(8@)
Object.RemoveReferences(16@)
Object.RemoveReferences(17@)
Object.RemoveReferences(18@)
Object.RemoveReferences(19@)
Object.RemoveReferences(20@)
Object.RemoveReferences(21@)
Object.RemoveReferences(22@)
Object.RemoveReferences(23@)
Object.RemoveReferences(24@)
Object.RemoveReferences(25@)
Model.Destroy(1224)
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:Z_N26
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N26
056D:   actor 1@ defined
else_jump @Z_N26
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N26
03A3:   actor 1@ male
else_jump @Z_N26
not Actor.Driving(1@)
else_jump @Z_N26
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N26
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N26
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N26
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N26
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N26
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N26
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N26
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N26
$ONMISSION == 0 
else_jump @Z_N26
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN26
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO26
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN6' time 5000 flag 1  //Нужно передать посылку одному человеку? Ты можешь помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться. 
$ONMISSION = 1                      

:KEY_Y26
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N26
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Model.Load(3052)
038B: load_requested_models
fade 0 1000 
wait 1500
Actor.StorePos($PLAYER_ACTOR, 67@, 68@, 69@)
68@ +=2.0
70@ = Object.Create(3052, 67@, 68@, 69@)
08E9: set_object 70@ liftable 1
07C9: AS_actor $PLAYER_ACTOR walk_to_object 70@ then_lift_and_hold_in_hands
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:FIDE_ENDL
wait 0
0737:   actor $PLAYER_ACTOR lifting_object 70@
else_jump @FIDE_ENDL
fade 1 1000 
wait 1000
08E9: set_object 70@ liftable 0
00BC: show_text_highpriority GXT 'CEEE6' time 5000 flag 1  //Дождитесь человека, который должен получить посылку.
0209: 17@ = random_int_in_ranges 10000 25000
wait 17@

:FIND_AL
wait 0
Actor.StorePos($PLAYER_ACTOR, 48@, 49@, 50@)
0AE1: 2@ = random_actor_near_point 48@ 49@ 50@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @FIND_AL
056D:   actor 2@ defined
else_jump @FIND_AL
089F: get_actor 2@ pedtype_to 30@
30@ == 4
else_jump @FIND_AL
03A3:   actor 2@ male
else_jump @FIND_AL
not Actor.Driving(2@)
else_jump @FIND_AL

:WALKL
Actor.StorePos($PLAYER_ACTOR, 71@, 72@, 73@) 
07CD: AS_actor 2@ walk_to 71@ 72@ 73@ stop_with_angle 270.0 within_radius 4.0

:POSLKA_ENDL
wait 0
0105:   actor 2@ near_actor $PLAYER_ACTOR radius 2.0 2.0 2.0 sphere 0 on_foot
else_jump @WALKL
Object.Destroy(70@)
Model.Destroy(3052)
0687: clear_actor $PLAYER_ACTOR task
0394: play_music 2
17@ = 1500
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
Actor.RemoveReferences(40@)
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER 

:KEY_N26
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y26
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136 
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Actor.RemoveReferences(1@)
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
0663: printint "TIME" 9@
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO26
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN26
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:Z_N27
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N27
056D:   actor 1@ defined
else_jump @Z_N27
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N27
03A3:   actor 1@ male
else_jump @Z_N27
not Actor.Driving(1@)
else_jump @Z_N27
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N27
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N27
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N27
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N27
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N27
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N27
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N27
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N27
$ONMISSION == 0 
else_jump @Z_N27
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN27
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO27
05C1: AS_actor 1@ speak_from_audio_table 166
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN7' time 5000 flag 1  //Я работаю курьером, мне нужно передать цветы одной девушки, но я не успеваю! Вы можете мне помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1                       

:KEY_Y27
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N27
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CZ27' time 5000 flag 1  //Отправляйся в район казино Кам-Э-Лот. //!!!!!
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
018A: 8@ = create_checkpoint_at 2517.6738 1159.0421 10.8203
08FB: set_checkpoint 8@ type_to 0
Model.Load(#flowera)
04ED: load_animation  "KISSING"
038B: load_requested_models
01B2: give_actor $PLAYER_ACTOR weapon 14 ammo 1 // Load the weapon model before using this
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:NEAR_FLOWERSL
wait 0
0101:   actor $PLAYER_ACTOR in_sphere 2517.6738 1159.0421 10.82035 radius 1.5 1.5 10.5 sphere 1.5 stopped
else_jump @NEAR_FLOWERSL

:DRIVE3
Actor.Driving($PLAYER_ACTOR)
else_jump @NEAR_FLOWERSL
00BC: show_text_highpriority GXT 'EEE7' time 1000 flag 1  //Стой здесь, пока не появится девушка, которой нужно отдать цветы. 
Actor.StorePos($PLAYER_ACTOR, 2@, 3@, 4@)
0AE1: 1@ = random_actor_near_point 2@ 3@ 4@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @NEAR_FLOWERSL
056D:   actor 1@ defined
else_jump @NEAR_FLOWERSL
089F: get_actor 1@ pedtype_to 30@
30@ == 5
else_jump @NEAR_FLOWERSL
not Actor.Driving(1@)
else_jump @NEAR_FLOWERSL
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @NEAR_FLOWERSL
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @NEAR_FLOWERSL
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @NEAR_FLOWERSL
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @NEAR_FLOWERSL
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @NEAR_FLOWERSL
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @NEAR_FLOWERSL
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @NEAR_FLOWERSL
Marker.CreateAboveActor(27@,1@)
Marker.SetColor(27@, 1)
00BC: show_text_highpriority GXT 'CHDE7' time 5000 flag 1  //Передай девушке цветы.
Marker.Disable(8@)


:FLOWERS_ENDL
wait 0
0105:   actor $PLAYER_ACTOR near_actor 1@ radius 2.0 2.0 2.0 sphere 0 on_foot
else_jump @FLOWERS_END_FAILL
0687: clear_actor $PLAYER_ACTOR task
0687: clear_actor 1@ task
0992: set_player $PLAYER_CHAR weapons_scrollable 0
01B9: set_actor $PLAYER_ACTOR armed_weapon_to 14
0639: AS_actor 1@ rotate_to_actor $PLAYER_ACTOR
0639: AS_actor $PLAYER_ACTOR rotate_to_actor 1@  
0605: actor $PLAYER_ACTOR perform_animation "gift_give" IFP "KISSING" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 5330
0605: actor 1@ perform_animation "gift_get" IFP "KISSING" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 5330  
04EF: release_animation "KISSING"
wait 5000
0992: set_player $PLAYER_CHAR weapons_scrollable 1
01B2: give_actor 1@ weapon 14 ammo 1 // Load the weapon model before using this
01B9: set_actor 1@ armed_weapon_to 14
0555: remove_weapon 14 from_actor $PLAYER_ACTOR
0394: play_music 2
17@ = 1000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:FLOWERS_END_FAILL
if or
856D:  not actor 1@ defined
Actor.Dead(1@)
8491:  not actor $PLAYER_ACTOR has_weapon 14
gosub @WASTED_OR_BUSTED
else_jump @FLOWERS_ENDL
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
Marker.Disable(27@)
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N27
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y27
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136 
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO27
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN27
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:Z_N28
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N28
056D:   actor 1@ defined
else_jump @Z_N28
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N28
03A3:   actor 1@ male
else_jump @Z_N28
not Actor.Driving(1@)
else_jump @Z_N28
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N28
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N28
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N28
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N28
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N28
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N28
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N28
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N28
$ONMISSION == 0 
else_jump @Z_N28
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN28
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO28
05C1: AS_actor 1@ speak_from_audio_table 166
Actor.StorePos(1@, 90@, 91@, 92@)
0665: get_actor 1@ model_to 93@
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CHDN9' time 5000 flag 1  //Мне кажется, моя девушка мне изменяет. Ты можешь помочь мне выявить её ухажера?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1                       

:KEY_Y28
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N28
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CDZ30' time 5000 flag 1  //Отправляйся в район казино Пираты в Портянках. //!!!!!
Model.Load(233)
Model.Load(185)
038B: load_requested_models
018A: 8@ = create_checkpoint_at 2046.9214 1529.162 10.6719
08FB: set_checkpoint 8@ type_to 0
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
Model.Load(233)
Model.Load(185)
Model.Load(#CAMERA)
04ED: load_animation  "KISSING"
038B: load_requested_models
01B2: give_actor $PLAYER_ACTOR weapon 43 ammo 999999 // Load the weapon model before using this
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:NEAR_PRL
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 2046.9214 1529.162 10.6719 radius 100.0 100.0 100.0
else_jump @NEAR_PRL
Marker.Disable(8@)
2@ = Actor.Create(4, 185, 2000.9473, 1566.9695, 15.3672)
3@ = Actor.Create(5, 233, 2000.6332, 1566.9695, 15.3672)
Actor.Angle(2@) = 86.5902
Actor.Angle(3@) = 269.0968
wait 500
0615: define_AS_pack_begin 18@
0605: actor -1 perform_animation "Grlfrd_Kiss_02" IFP "KISSING" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1
0618: assign_actor 3@ to_AS_pack 18@
0643: set_AS_pack 18@ loop 1
//*************************//
Marker.CreateAboveActor(97@, 2@)
Marker.CreateAboveActor(98@, 3@)
00BC: show_text_highpriority GXT 'CHDE9' time 5000 flag 1  //Сфотографируй измену. Не подходи к ним слишком близко.

:PHOTOL
wait 0
if and
04C5:   actor 2@ photographed
04C5:   actor 3@ photographed
else_jump @PHOTO_FAILL
Marker.Disable(97@)
Marker.Disable(98@)                                                            
00BC: show_text_highpriority GXT 'CEDE9' time 5000 flag 1  //Передай фотографию человеку.
018A: 8@ = create_checkpoint_at 90@ 91@ 92@
08FB: set_checkpoint 8@ type_to 0
Model.Load(93@)
038B: load_requested_models
jump @PHOTO_END1L

:PHOTO_END1L
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 90@ 91@ 92@ radius 100.0 100.0 100.0
else_jump @PHOTO_END1L
1@ = Actor.Create(CivMale, 93@, 90@, 91@, 92@)
jump @PHOTO_END2L

:PHOTO_FAILL
if or
00F2:   actor $PLAYER_ACTOR near_actor 2@ radius 20.0 20.0 sphere 0
00F2:   actor $PLAYER_ACTOR near_actor 3@ radius 20.0 20.0 sphere 0
gosub @WASTED_OR_BUSTED
else_jump @PHOTOL
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
0616: define_AS_pack_end 18@
0616: define_AS_pack_end 19@
061B: remove_references_to_AS_pack 18@ 
061B: remove_references_to_AS_pack 19@
Marker.Disable(97@)
Marker.Disable(98@)
Actor.RemoveReferences(2@)
Actor.RemoveReferences(3@) 
Marker.Disable(8@)
Model.Destroy(233)
Model.Destroy(185)
Model.Destroy(#CAMERA)
04EF: release_animation  "KISSING"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:PHOTO_END2L
wait 0
0105:   actor $PLAYER_ACTOR near_actor 1@ radius 2.0 2.0 2.0 sphere 0 on_foot
else_jump @PHOTO_END2_FAILL
Marker.Disable(8@)
0687: clear_actor $PLAYER_ACTOR task
0687: clear_actor 1@ task
0639: AS_actor 1@ rotate_to_actor $PLAYER_ACTOR
0639: AS_actor $PLAYER_ACTOR rotate_to_actor 1@  
0605: actor $PLAYER_ACTOR perform_animation "ATM" IFP "PED" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 2008  
wait 2008
0394: play_music 2
17@ = 5000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
Marker.Disable(94@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
Model.Destroy(233)
Model.Destroy(185)
Model.Destroy(#CAMERA)
04EF: release_animation  "KISSING"
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:PHOTO_END2_FAILL
if or
856D:  not actor 1@ defined
Actor.Dead(1@)
8491:  not actor $PLAYER_ACTOR has_weapon 43
gosub @WASTED_OR_BUSTED
else_jump @PHOTO_END2L
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
Marker.Disable(27@)
Marker.Disable(8@)
Actor.RemoveReferences(1@)
Model.Destroy(233)
Model.Destroy(185)
Model.Destroy(#CAMERA)
04EF: release_animation  "KISSING"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @TIMER

:KEY_N28
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y28 
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO28
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN28
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:Z_N29
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N29
056D:   actor 1@ defined
else_jump @Z_N29
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N29
03A3:   actor 1@ male
else_jump @Z_N29
not Actor.Driving(1@)
else_jump @Z_N29
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N29
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N29
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N29
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N29
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N29
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N29
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N29
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N29
$ONMISSION == 0 
else_jump @Z_N29
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN29
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO29
05C1: AS_actor 1@ speak_from_audio_table 166
0665: get_actor 1@ model_to 93@
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CDN10' time 5000 flag 1  //Нужно украсть одну вещь из дома, ты можешь помочь?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1                       

:KEY_Y29
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N29
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CZ29' time 5000 flag 1  //Ограбь дом в районе Западный Редсандз. //!!!!!
0A40: 2@ = create_entrance_marker_at 1640.3518 2075.8064 11.3125 color 14
018A: 8@ = create_checkpoint_at 1640.3518 2075.8064 11.3125
08FB: set_checkpoint 8@ type_to 0
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"

:ENTERL
wait 0
00ED:   actor $PLAYER_ACTOR sphere 0 near_point 1640.3518 2075.8064 radius 2.0 2.0 on_foot
else_jump @ENTERL
Marker.Disable(8@)
0A41: destroy_entrance_marker 2@
fade 0 1000 
wait 1500
select_interior 2
0860: link_actor $PLAYER_ACTOR to_interior 2
Actor.PutAt($PLAYER_ACTOR, 224.7515, 1240.0166, 1082.1406)
3@ = Pickup.Create(1581, 3, 224.871, 1253.1106, 1082.1406)
03DC: 4@ = create_marker_above_pickup 3@
Marker.SetColor(4@, 1)
fade 1 1000 
wait 1000
00BC: show_text_highpriority GXT 'CDZ10' time 5000 flag 1  //Подбери вещь, которая нужна человеку.
08E7: disable_entrance_markers 1

:PIK_UPL
wait 0
Pickup.Picked_up(3@)
else_jump @PIK_UPL
0A40: 2@ = create_entrance_marker_at 2066.9763 -1656.5579 15.075 color 14
018A: 8@ = create_checkpoint_at 2066.9763 -1656.5579 14.075
08FB: set_checkpoint 8@ type_to 0
00BC: show_text_highpriority GXT 'CDE10' time 5000 flag 1  //Направляйся к выходу
Model.Load(93@)
038B: load_requested_models

:EXITL
wait 0
00ED:   actor $PLAYER_ACTOR sphere 0 near_point 226.6236 1240.0719 radius 2.0 2.0 on_foot
else_jump @EXITL
Marker.Disable(8@)
0A41: destroy_entrance_marker 2@
fade 0 1000 
wait 1500
select_interior 0
0860: link_actor $PLAYER_ACTOR to_interior 0
Actor.PutAt($PLAYER_ACTOR, 1635.6931, 2078.9565, 11.3125)
1@ = Actor.Create(CivMale, 93@, 1634.0275, 2079.2163, 11.2206)
Actor.Angle(1@) = 269.45
fade 1 1000 
wait 1000
0687: clear_actor $PLAYER_ACTOR task
0687: clear_actor 1@ task
0639: AS_actor 1@ rotate_to_actor $PLAYER_ACTOR
0639: AS_actor $PLAYER_ACTOR rotate_to_actor 1@  
0605: actor $PLAYER_ACTOR perform_animation "ATM" IFP "PED" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 2008  
wait 2008
0394: play_music 2
17@ = 10000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
Marker.Disable(94@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @TIMER

:KEY_N29
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y29
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136 
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6 
$ONMISSION = 0
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO29
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN29
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random

:Z_N30
wait 0
actor.StorePos($PLAYER_ACTOR, 0@, 1@, 2@) 
0AE1: 1@ = random_actor_near_point 0@ 1@ 2@ in_radius 10.0 find_next 0 pass_deads 0
else_jump @Z_N30
056D:   actor 1@ defined
else_jump @Z_N30
089F: get_actor 1@ pedtype_to 30@
30@ == 4
else_jump @Z_N30
03A3:   actor 1@ male
else_jump @Z_N30
not Actor.Driving(1@)
else_jump @Z_N30
if or
874F:  not actor 1@ ped_event == 9
874F:  not actor 1@ ped_event == 10
else_jump @Z_N30
if or
874F: not  actor 1@ ped_event == 11
874F: not  actor 1@ ped_event == 17
else_jump @Z_N30
if or
874F: not  actor 1@ ped_event == 18
874F: not  actor 1@ ped_event == 26
else_jump @Z_N30
if or
874F: not  actor 1@ ped_event == 28
874F: not  actor 1@ ped_event == 36
else_jump @Z_N30
if or
874F: not  actor 1@ ped_event == 37
874F: not  actor 1@ ped_event == 50
else_jump @Z_N30
if or
874F: not  actor 1@ ped_event == 51
874F: not  actor 1@ ped_event == 58
else_jump @Z_N30
if or
874F: not  actor 1@ ped_event == 63
874F: not  actor 1@ ped_event == 65
else_jump @Z_N30
not Actor.Driving($PLAYER_ACTOR)
else_jump @Z_N30
$ONMISSION == 0 
else_jump @Z_N30
Marker.CreateAboveActor(27@,1@)
07E0: set_marker 27@ type_to 1

:run_to_actorN30
wait 0
00F3:   actor 1@ near_actor $PLAYER_ACTOR radius 3.0 3.0 sphere 0 on_foot
else_jump @run_to_actorNO30
05C1: AS_actor 1@ speak_from_audio_table 166
0665: get_actor 1@ model_to 93@
0850: AS_actor 1@ follow_actor $PLAYER_ACTOR
00BC: show_text_highpriority GXT 'CZN30' time 5000 flag 1  //Сейчас на площади Лас Вентураса идет выбор нового мэра, ты можешь сорвать эти выборы?
03E5: show_text_box 'CHDN_H'  // Нажмите Y, чтобы выполнить поручение, или N, чтобы отказаться.
$ONMISSION = 1                       

:KEY_Y30
wait 0
if and
0ADC:   test_cheat "Y"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_N30
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 132
00BC: show_text_highpriority GXT 'CHZ30' time 5000 flag 1  //Сорви выборы на площади в районе Рока Эскаланте.
018A: 88@ = create_checkpoint_at 2316.8989 2362.5833 11.2734
08FB: set_checkpoint 88@ type_to 0
Model.Load(#SWMYRI)
Model.Load(#MALE01)
Model.Load(#BFYRI)
Model.Load(#BMORI)
Model.Load(#BFYST)
Model.Load(#HFORI)
Model.Load(#WBDYG2)
Model.Load(#WMYCON)
Model.Load(#HMORI)
Model.Load(#OFYST)
Model.Load(#WFYSTEW)
Model.Load(#BMYBOUN)
Model.Load(#WMYBOUN)
038B: load_requested_models
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
900@ = 0
0AF0: 900@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Y"
900@ += 1
0AF1: write_int 900@ to_ini_file "data\Paths\Stats" section "MyStats" key "Y"


:NEAR_SQL
wait 0
00FE:   actor $PLAYER_ACTOR sphere 0 in_sphere 2314.9724 2412.1643 10.6719 radius 200.0 200.0 100.0
else_jump @NEAR_SQL
0@ = Actor.Create(4, #SWMYRI, 2316.8989, 2362.5833, 11.2734)//0
1@ = Actor.Create(4, #MALE01, 2318.8904, 2367.6853, 10.8203)
2@ = Actor.Create(5, #BFYRI, 2317.6138, 2367.449, 10.8203)
3@ = Actor.Create(4, #BMORI, 2315.947, 2367.2473, 10.8203)
4@ = Actor.Create(5, #BFYST, 2319.0833, 2368.823, 10.8203)
5@ = Actor.Create(5, #HFORI, 2317.4238, 2368.5691, 10.8203)
6@ = Actor.Create(4, #WBDYG2, 2316.0781, 2369.0569, 10.8203)
7@ = Actor.Create(4, #WMYCON, 2319.0095, 2369.9492, 10.8203)
8@ = Actor.Create(4, #HMORI, 2317.0923, 2371.0823, 10.8203)
9@ = Actor.Create(5, #OFYST, 2315.2163, 2370.8193, 10.8203)
10@ = Actor.Create(5, #WFYSTEW, 2319.0823, 2371.4998, 10.8203) 
11@ = Actor.Create(4, #BMYBOUN, 2314.7593, 2363.4089, 10.8203)//1
12@ = Actor.Create(4, #WMYBOUN, 2319.1794, 2363.2729, 10.8203)//2
Actor.Angle(0@) = 358.4283
Actor.Angle(1@) = 177.8251
Actor.Angle(2@) = 177.1984
Actor.Angle(3@) = 177.1984//
Actor.Angle(4@) = 177.1984
Actor.Angle(5@) = 177.1984
Actor.Angle(6@) = 177.1984
Actor.Angle(7@) = 177.1984
Actor.Angle(8@) = 177.1984
Actor.Angle(9@) = 177.1984
Actor.Angle(10@) = 177.1984
Actor.Angle(11@) = 358.6237
Actor.Angle(12@) = 358.6237
//
0615: define_AS_pack_begin 18@
0605: actor -1 perform_animation "IDLE_CHAT" IFP "PED" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1
0618: assign_actor 0@ to_AS_pack 18@
0643: set_AS_pack 18@ loop 1
//
00BC: show_text_highpriority GXT 'CHE10' time 5000 flag 1  //Спровоцируй драку в толпе, ударив любого находящегося на площади человека.

:DAMAGEL
wait 0
if or
gosub @DAMAGE_A
gosub @DAMAGE_B
else_jump @DAMAGE_FAILL
not Actor.Driving($PLAYER_ACTOR)
else_jump @DAMAGE_FAILL
00BC: show_text_highpriority GXT 'CHX10' time 3000 flag 1  //(Голос из толпы): Эй, кто меня ударил?
wait 3000
00BC: show_text_highpriority GXT 'CHX11' time 5000 flag 1  //(Голос из толпы): Ты это мне?!
wait 1000
05E2: AS_actor 1@ kill_actor 2@
05E2: AS_actor 2@ kill_actor 1@
05E2: AS_actor 3@ kill_actor 4@
05E2: AS_actor 4@ kill_actor 3@
05E2: AS_actor 5@ kill_actor 6@
05E2: AS_actor 6@ kill_actor 7@
05E2: AS_actor 7@ kill_actor 8@
05E2: AS_actor 8@ kill_actor 7@
05E2: AS_actor 9@ kill_actor 10@
05E2: AS_actor 10@ kill_actor 9@
05E2: AS_actor 11@ kill_actor 6@
05E2: AS_actor 12@ kill_actor 5@
05C3: AS_actor 0@ hands_cower
Marker.Disable(88@)
0394: play_music 2
Actor.StorePos($PLAYER_ACTOR, 55@, 66@, 77@)
17@ = 15000
0109: player $PLAYER_CHAR money += 17@
01E3: show_text_1number_styled GXT "CHZPS" number 17@ time 1000 style 1
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Passed"
wait 8000
0513: show_text_box_1number 'ERRT' number 2@
jump @DESTROYL

:DAMAGE_FAILL
if or
051A:   actor 0@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 11@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 12@ damaged_by_actor $PLAYER_ACTOR
gosub @WASTED_OR_BUSTED
else_jump @DAMAGE_GCARL
Marker.Disable(88@)
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
jump @DESTROYL

:DAMAGE_GCARL
Actor.Driving($PLAYER_ACTOR)
else_jump @DAMAGEL
99@ = Actor.CurrentCar($PLAYER_ACTOR)
if or
gosub @DAMAGE_C
gosub @DAMAGE_D
else_jump @DAMAGEL
Marker.Disable(88@)
00BA: show_text_styled GXT "CHZF" time 1000 style 1  // Поручение провалено!
$ONMISSION = 0
903@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
903@ += 1
0AF1: write_int 903@ to_ini_file "data\Paths\Stats" section "MyStats" key "Failed"
jump @DESTROYL

:DESTROYL
wait 0
80FE:  not actor $PLAYER_ACTOR sphere 0 in_sphere 55@ 66@ 77@ radius 100.0 100.0 100.0
else_jump @DESTROYL
Actor.RemoveReferences(0@)
Actor.RemoveReferences(1@)
Actor.RemoveReferences(2@)
Actor.RemoveReferences(3@)
Actor.RemoveReferences(4@)
Actor.RemoveReferences(5@)
Actor.RemoveReferences(6@)
Actor.RemoveReferences(7@)
Actor.RemoveReferences(8@)
Actor.RemoveReferences(9@)
Actor.RemoveReferences(10@)
Actor.RemoveReferences(11@)
Actor.RemoveReferences(12@)
Model.Destroy(#SWMYRI)
Model.Destroy(#MALE01)
Model.Destroy(#BFYRI)
Model.Destroy(#BMORI)
Model.Destroy(#BFYST)
Model.Destroy(#HFORI)
Model.Destroy(#WBDYG2)
Model.Destroy(#WMYCON)
Model.Destroy(#HMORI)
Model.Destroy(#OFYST)
Model.Destroy(#WFYSTEW)
Model.Destroy(#BMYBOUN)
Model.Destroy(#WMYBOUN)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
jump @TIMER

:KEY_N30
if and
0ADC:   test_cheat "N"
00F3:   actor $PLAYER_ACTOR near_actor 1@ radius 4.0 4.0 sphere 0 on_foot
else_jump @KEY_Y30 
05C1: AS_actor 1@ speak_from_audio_table 168
05C1: AS_actor $PLAYER_ACTOR speak_from_audio_table 136
00BA: show_text_styled GXT "CHZPАC" time 1000 style 1
Marker.Disable(27@)
05DE: AS_actor 1@ walk_around_ped_path
Actor.RemoveReferences(1@)
00BF: 9@ = current_time_hours, 10@ = current_time_minutes 
9@ += 6
0663: printint "TIME" 9@
$ONMISSION = 0 
901@ = 0
0AF0: 901@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "N"
901@ += 1
0AF1: write_int 901@ to_ini_file "data\Paths\Stats" section "MyStats" key "N"
jump @TIMER

:run_to_actorNO30
wait 0
80F3:  not actor $PLAYER_ACTOR near_actor 1@ radius 10.0 10.0 sphere 0 on_foot
else_jump @run_to_actorN30
Marker.Disable(27@)
904@ = 0
0AF0: 904@ = get_int_from_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
904@ += 1
0AF1: write_int 904@ to_ini_file "data\Paths\Stats" section "MyStats" key "Ignore"
jump @random
//********************************************************************************//

:DAMAGE_A
if or
051A:   actor 1@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 2@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 3@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 4@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 5@ damaged_by_actor $PLAYER_ACTOR
else_jump @DAMAGE_FALSE
return

:DAMAGE_B
if or
051A:   actor 6@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 7@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 8@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 9@ damaged_by_actor $PLAYER_ACTOR
051A:   actor 10@ damaged_by_actor $PLAYER_ACTOR
else_jump @DAMAGE_FALSE
return

:DAMAGE_C
if or
051B:   actor 1@ damaged_by_car 99@
051B:   actor 2@ damaged_by_car 99@
051B:   actor 3@ damaged_by_car 99@
051B:   actor 4@ damaged_by_car 99@
051B:   actor 5@ damaged_by_car 99@
else_jump @DAMAGE_FALSE
return

:DAMAGE_D
if or
051B:   actor 0@ damaged_by_car 99@
051B:   actor 6@ damaged_by_car 99@
051B:   actor 7@ damaged_by_car 99@
051B:   actor 8@ damaged_by_car 99@
051B:   actor 9@ damaged_by_car 99@
051B:   actor 10@ damaged_by_car 99@
051B:   actor 11@ damaged_by_car 99@
051B:   actor 12@ damaged_by_car 99@
else_jump @DAMAGE_FALSE
return

:DAMAGE_FALSE
return

:WASTED_OR_BUSTED
if or
0117:   player $PLAYER_CHAR wasted
0741:   actor $PLAYER_ACTOR busted
else_jump @WASTED_OR_BUSTED_F
return

:WASTED_OR_BUSTED_F
return

:TIMER
0AF0: 3@ = get_int_from_ini_file "cleo\Settings.ini" section "TIMER" key "VALUE"
if and
3@ > 0
7 > 3@
else_jump @TIMER_INI_D

:T_1
wait 0
3@ == 1
else_jump @T_2
386@ = 60
03E5: show_text_box 'TART'
wait 6000 
jump @TIMER_START

:T_2
3@ == 2
else_jump @T_3
386@ = 120
0513: show_text_box_1number 'TBRT' number 3@
wait 6000  
jump @TIMER_START

:T_3
3@ == 3
else_jump @T_4
386@ = 180
0513: show_text_box_1number 'TBRT' number 3@

wait 6000  
jump @TIMER_START

:T_4
wait 0
3@ == 4
else_jump @T_5
386@ = 240
0513: show_text_box_1number 'TBRT' number 3@
wait 6000  
jump @TIMER_START

:T_5
3@ == 5
else_jump @T_6
386@ = 300
0513: show_text_box_1number 'TCRT' number 3@
wait 6000 
jump @TIMER_START

:T_6
3@ == 6
else_jump @T_1
386@ = 360
0513: show_text_box_1number 'TCRT' number 3@
wait 6000
jump @TIMER_START

:TIMER_INI_D
386@ = 360
0AF1: write_int 386@ to_ini_file "cleo\Settings.ini" section "TIMER" key "VALUE"
03E5: show_text_box 'TCRT'
wait 6000
jump @TIMER_START

:TIMER_START
FOR 390@ = 0 TO 386@ step 1
0663: printint "TIMER_FIX" 390@
wait 1000
end

:end_time
03E5: show_text_box 'TRRT'
wait 6000
jump @random
