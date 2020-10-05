# Infusion Gateway Demo

This project provides an example of how to use the `ibsgateway831.dll` to connect to the Infusion Accounting software and read/write to it's database.

All methods for the IBSGateway dll have been dissassembled and can be found [here](./ibsgateway-info.md);
<br><br>

## Example

The following is the output when running the current code against the Infusion Demo Database

```
PS Z:\InfusionGateway> dotnet run
75
Account: 1000, Name: Alice Smith                             , Address: 154 Cashel Street, Ashburton
Account: 1001, Name: Allan Anderson                          , Address: 157 Main North Road, Christchurch
Account: 1002, Name: Amber Thompson                          , Address: 160 High Street, Auckland
Account: 1003, Name: Andrea Hill                             , Address: 163 Lower Ave, Wellington
Account: 1004, Name: Andrew Hills                            , Address: 166 Brick Place, Napier
Account: 1005, Name: Angus Swift                             , Address: 169 Anderson Bay Road, New Plymouth
Account: 1006, Name: Anthony Bander                          , Address: 172 Hilltop Drive, Dunedin
Account: 1007, Name: Barry Conners                           , Address: 175 Longreach Ave, Botany
Account: 1008, Name: Belinda Davidson                        , Address: 178 Blenheim Road, Timaru
Account: 1009, Name: Bill Coffee                             , Address: 181 Albert Drive, Ashburton
Account: 1010, Name: Bob Deverson                            , Address: 184 Benmark Street, Christchurch
Account: 1011, Name: Brent Emerson                           , Address: 187 Canton Lane, Auckland
Account: 1012, Name: Britney Ellis                           , Address: 190 Downing Drive, Wellington
Account: 1013, Name: Caitlin Edwards                         , Address: 193 Elite Street, Napier
Account: 1014, Name: Colin Edinghouse                        , Address: 196 Francis Avenue, New Plymouth
Account: 1015, Name: Craig Flowerston                        , Address: 199 Grander St, Dunedin
Account: 1016, Name: David Georgison                         , Address: 202 Cameron Drive, Botany
Account: 1017, Name: Dan Gables                              , Address: 205 Harvey Lane, Timaru
Account: 1018, Name: Debbie Handle                           , Address: 208 Linwood Street, Ashburton
Account: 1020, Name: Edward Harvey                           , Address: 214 Northwood Road, Auckland
Account: 1021, Name: Ellen Interco Ltd                       , Address: 217 Cashel Street, Wellington
Account: 1022, Name: Fiona James                             , Address: 220 Main North Road, Napier
Account: 1023, Name: Fred Jones                              , Address: 223 High Street, New Plymouth
Account: 1024, Name: George Johnston                         , Address: 226 Lower Ave, Dunedin
Account: 1025, Name: Hamish Johns                            , Address: 229 Brick Place, Botany
Account: 1026, Name: Harry Helms                             , Address: 232 Anderson Bay Road, Timaru
Account: 1027, Name: Ian Longby                              , Address: 235 Hilltop Drive, Ashburton
Account: 1028, Name: James Mathewson                         , Address: 238 Longreach Ave, Christchurch
Account: 1029, Name: Jane Matthews                           , Address: 241 Blenheim Road, Auckland
Account: 1030, Name: Janine Norman                           , Address: 244 Albert Drive, Wellington
Account: 1031, Name: Jessica Ottway                          , Address: 247 Benmark Street, Napier
Account: 1032, Name: Jim Orange                              , Address: 250 Canton Lane, New Plymouth
Account: 1033, Name: John Peterson                           , Address: 253 Downing Drive, Dunedin
Account: 1034, Name: Catherine Peters                        , Address: 256 Elite Street, Botany
Account: 1035, Name: Kate Redmond                            , Address: 259 Francis Avenue, Timaru
Account: 1036, Name: Kelvin Rogers                           , Address: 262 Grander St, Ashburton
Account: 1037, Name: Kevin Stenway                           , Address: 265 Cameron Drive, Christchurch
Account: 1038, Name: Larry Simpson                           , Address: 268 Harvey Lane, Auckland
Account: 1039, Name: Liam Victor                             , Address: 271 Linwood Street, Wellington
Account: 1040, Name: Lisa Wallis                             , Address: 274 Mason Drive, Napier
Account: 1041, Name: Lucy Yang                               , Address: 277 Northwood Road, New Plymouth
Account: 1042, Name: Martin Zen                              , Address: 280 Anderson Drive, Dunedin
Account: 1043, Name: Martin Yee                              , Address: 283 Hillsway Ave, Botany
Account: 1044, Name: Jim and Tom's Mower Services Ltd        , Address: 286 Power Drive, Timaru
Account: 1045, Name: Bottles and Caps Limited                , Address: 289 Cashel Street, Ashburton
Account: 1046, Name: Cat Food Supplies Limited               , Address: 292 Main North Road, Christchurch
Account: 1047, Name: Davidson and Thompson Ltd               , Address: 295 High Street, Auckland
Account: 1048, Name: Edwards Milk Supplies Ltd               , Address: 298 Lower Ave, Wellington
Account: 1049, Name: Fresh Flowers for You Ltd               , Address: 301 Brick Place, Napier
Account: 1050, Name: Green Grass Cutters Ltd                 , Address: 304 Anderson Bay Road, New Plymouth
Account: 1051, Name: Home and House Painters Ltd             , Address: 307 Hilltop Drive, Dunedin
Account: 1052, Name: Inland Transport Supplies               , Address: 310 Longreach Ave, Botany
Account: 1053, Name: Action Travel                           , Address: 313 Blenheim Road, Timaru
Account: 1054, Name: International Dog Transport Ltd         , Address: 316 Albert Drive, Ashburton
Account: 1055, Name: Bob and Tom Support Services            , Address: 319 Benmark Street, Christchurch
Account: 1056, Name: Ellen James Windows                     , Address: 322 Canton Lane, Auckland
Account: 1057, Name: Anderson Furniture Supplies             , Address: 325 Downing Drive, Wellington
Account: 1058, Name: Jim's Household Cleaners Limited        , Address: 328 Elite Street, Napier
Account: 1059, Name: Albon Childcare                         , Address: 331 Francis Avenue, New Plymouth
Account: 1060, Name: Cleaning and Printing Solutions         , Address: 334 Grander St, Dunedin
Account: 1061, Name: The Computer Shop                       , Address: 337 Cameron Drive, Botany
Account: 1062, Name: Tasker Construction                     , Address: 340 Harvey Lane, Timaru
Account: 1063, Name: Auckland Fine Wines                     , Address: 343 Linwood Street, Ashburton
Account: 1064, Name: The Muffin Man                          , Address: 346 Mason Drive, Christchurch
Account: 1065, Name: Tom Smith                               , Address: 157 High Street, Rangioria
Account: 1066, Name: Bob Anderson                            , Address: 43 Longgraft Road, Wigram
Account: 1067, Name: Donald Holt                             , Address: 211 Mason Drive, Christchurch
Account: 1068, Name: Edward Jamison                          , Address: 56 Blake Street, South Auckland
Account: 1069, Name: Bob Henderson                           , Address: 56 Great South Road, Botany
Account: 1070, Name: Andy Jones                              , Address: 881 Hight Street, Rangiora
Account: 1071, Name: Cash Sale Account                       , Address: 99 Greatway Road, Auckland
Account: 1072, Name: Internal Customer                       , Address: ,
Account: 1073, Name: Swift Mowers Ltd                        , Address: PO Box 4875, Ellerslie
Account: 1074, Name: Swift Mowers Wellington Ltd             , Address: PO Box 7748, Riversdale
Account: 1075, Name: Swift Mowers Auckland Ltd               , Address: PO Box 11475, North Shore Mail Centre
PINVNUMBER: 10655, PACCOUNT: 1000, PDATE: 10/5/2020 1:17:59 PM, PLOCATION: 1
2112
```
