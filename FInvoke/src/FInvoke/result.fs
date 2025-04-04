module FInvoke.Result

let inline invoke func arg =
    try Ok <| func arg with ex -> Error ex

let inline invoke2 func arg1 arg2 =
    invoke func (arg1, arg2)

let inline invoke3 func arg1 arg2 arg3 =
    invoke func (arg1, arg2, arg3)

let inline invoke4 func arg1 arg2 arg3 arg4 =
    invoke func (arg1, arg2, arg3, arg4)

let inline invoke5 func arg1 arg2 arg3 arg4 arg5 =
    invoke func (arg1, arg2, arg3, arg4, arg5)

let inline invoke6 func arg1 arg2 arg3 arg4 arg5 arg6 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6)

let inline invoke7 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7)

let inline invoke8 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)

let inline invoke9 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)

let inline invoke10 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)

let inline invoke11 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)

let inline invoke12 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)

let inline invoke13 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)

let inline invoke14 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)

let inline invoke15 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)

let inline invoke16 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 arg16 =
    invoke func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)
