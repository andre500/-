:NO_WLVL
2@ += 1
0AF1: write_int 2@ to_ini_file "data\paths\zmbmap.dat" section "Main" key "Wlvl"
wait 5000
jump @PLAYER

:BLOOD
wait 0
016F: create_particle 6 rotation_factor 180.0 size 2.0 intensity 255 flags 255 0 0 at -1932.3003 680.644 21.9317
016F: create_particle 6 rotation_factor 180.0 size 2.0 intensity 255 flags 255 0 0 at -1935.224 679.5813 21.6917
016F: create_particle 6 rotation_factor 180.0 size 2.0 intensity 255 flags 255 0 0 at -1931.1677 675.9976 21.6917
016F: create_particle 6 rotation_factor 180.0 size 2.0 intensity 255 flags 255 0 0 at -1934.4121 672.6304 21.6917
jump @BLOOD

:CreateThread
0A9F: 32@ = current_thread_pointer 
000A: 32@ += 0x10
0A8D: 32@ = read_memory 32@ size 4 virtual_protect 0
0062: 32@ -= 0@
0AA7: call_function 0x464C20 num_params 1 pop 1 32@ 33@
005A: 32@ += 0@
000A: 33@ += 0x10
0A8C: write_memory 33@ size 4 value 32@ virtual_protect 0
000A: 33@ += 0x2C
for 32@ = 0 to 30
0A8C: write_memory 33@ size 4 value 1@(32@,30i) virtual_protect 0
000A: 33@ += 4
end
0AB2: ret 0
