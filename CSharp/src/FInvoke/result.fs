module FInvoke.Result

let invoke func arg =
    try Ok <| func arg with ex -> Error ex

let invoke2 func arg1 arg2 =
    invoke func (arg1, arg2)

let invoke3 func arg1 arg2 arg3 =
    invoke func (arg1, arg2, arg3)

let invoke4 func arg1 arg2 arg3 arg4 =
    invoke func (arg1, arg2, arg3, arg4)

let invoke5 func arg1 arg2 arg3 arg4 arg5 =
    invoke func (arg1, arg2, arg3, arg4, arg5)

let invoke6 func arg1 arg2 arg3 arg4 arg5 arg6 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6)

let invoke7 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7)

let invoke8 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)

let invoke9 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)

let invoke10 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)

let invoke11 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)

let invoke12 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)

let invoke13 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)

let invoke14 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)

let invoke15 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)

let invoke16 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 arg16 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)
