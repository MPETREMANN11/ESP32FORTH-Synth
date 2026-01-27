\ *************************************
\ Notes definition for ESP32 Synth.
\    Filename:      defNotes.fs
\    Date:          26 jan 2026
\    Updated:       26 jan 2026
\    File Version:  1.0
\    MCU:           ESP32-S3 - ESP32 WROOM
\    Forth:         ESP32forth all versions 7.0.7.21+
\    Copyright:     Marc PETREMANN
\    Author:        Marc PETREMANN
\    GNU General Public License
\ **************************************


RECORDFILE /spiffs/defNotes.fs

vocabulary notes

\ define a musical note
: note: ( comp: n -- <name> | exec: -- n )
    create 
        ,
    does>
        @
  ;

notes definitions

\ Centi-Hz (Hz * 100)
  1635 note: c0       1732 note: cs0 
  1835 note: d0       1945 note: ds0 
  2060 note: e0 
  2183 note: f0       2312 note: fs0 
  2450 note: g0       2596 note: gs0 
  2750 note: a0       2914 note: as0 
  3087 note: b0 

  3270 note: c1       3465 note: cs1 
  3671 note: d1       3889 note: ds1 
  4120 note: e1 
  4365 note: f1       4625 note: fs1      
  4900 note: g1       5191 note: gs1 
  5500 note: a1 
  5827 note: as1      6174 note: b1 

  6541 note: c2       6930 note: cs2 
  7342 note: d2       7778 note: ds2 
  8241 note: e2 
  8731 note: f2       9250 note: fs2 
  9800 note: g2      10383 note: gs2 
 11000 note: a2      11654 note: as2 
 12347 note: b2 

 13081 note: c3      13859 note: cs3 
 14683 note: d3      15556 note: ds3 
 16481 note: e3 
 17461 note: f3      18500 note: fs3 
 19600 note: g3      20765 note: gs3 
 22000 note: a3      23308 note: as3 
 24694 note: b3 


 26163 note: c4      27718 note: cs4 
 29366 note: d4      31113 note: ds4 
 32963 note: e4 
 34923 note: f4      36999 note: fs4 
 39200 note: g4      41530 note: gs4 
 44000 note: a4      46616 note: as4 
 49388 note: b4 


 52325 note: c5      55437 note: cs5 
 58733 note: d5      62225 note: ds5 
 65925 note: e5 
 69846 note: f5      73999 note: fs5 
 78399 note: g5      83061 note: gs5 
 88000 note: a5      93233 note: as5 
 98777 note: b5 

104650 note: c6     110873 note: cs6 
117466 note: d6     124451 note: ds6 
131851 note: e6 
139691 note: f6     147998 note: fs6 
156798 note: g6     166122 note: gs6 
176000 note: a6     186466 note: as6 
197553 note: b6 

209300 note: c7     221746 note: cs7 
234932 note: d7     248902 note: ds7 
263702 note: e7 
279383 note: f7     295996 note: fs7 
313596 note: g7     332244 note: gs7 
352000 note: a7     372931 note: as7 
395107 note: b7 

418601 note: c8     443492 note: cs8 
469864 note: d8     497803 note: ds8 
527404 note: e8 
558765 note: f8     591991 note: fs8 
627193 note: g8     664488 note: gs8 
704000 note: a8     745862 note: as8 
790213 note: b8 

forth definitions

<EOF>



#define c5 52325
#define cs5 55437
#define d5 58733
#define ds5 62225
#define e5 65925
#define f5 69846
#define fs5 73999
#define g5 78399
#define gs5 83061
#define a5 88000
#define as5 93233
#define b5 98777

#define c6 104650
#define cs6 110873
#define d6 117466
#define ds6 124451
#define e6 131851
#define f6 139691
#define fs6 147998
#define g6 156798
#define gs6 166122
#define a6 176000
#define as6 186466
#define b6 197553

#define c7 209300
#define cs7 221746
#define d7 234932
#define ds7 248902
#define e7 263702
#define f7 279383
#define fs7 295996
#define g7 313596
#define gs7 332244
#define a7 352000
#define as7 372931
#define b7 395107
#define c8 418601
#define cs8 443492
#define d8 469864
#define ds8 497803
#define e8 527404
#define f8 558765
#define fs8 591991
#define g8 627193
#define gs8 664488
#define a8 704000
#define as8 745862
#define b8 790213

// --- OITAVA 9 (Ultrassom para humanos velhos, audível pra jovens e gatos) ---
#define c9 837202
#define cs9 886984
#define d9 939727
#define ds9 995606
#define e9 1054808
#define f9 1117530
#define fs9 1183982
#define g9 1254385
#define gs9 1328975
#define a9 1408000
#define as9 1491724
#define b9 1580427

// --- OITAVA 10 (O Limite de Nyquist @ 48kHz/52kHz) ---
// Cuidado: Nessas frequências, qualquer wavetable que não seja SINE pode distorcer.
#define c10 1674404
#define cs10 1773969
#define d10 1879455
#define ds10 1991213
#define e10 2109616
#define f10 2235061
#define fs10 2367964
#define g10 2508771

inline uint32_t midiToFreq(uint8_t note) {
    return (uint32_t)(44000.0 * pow(2.0, (note - 69) / 12.0));
}
#endif





