namespace Foo

module Func =
    let invoke func arg =
        try
            let res = func arg
            Ok res
        with ex ->
            Error ex

    let invoke2 func arg1 arg2 =
        try
            let res = func (arg1, arg2)
            Ok res
        with ex ->
            Error ex

    let invoke3 func arg1 arg2 arg3 =
        try
            let res = func (arg1, arg2, arg3)
            Ok res
        with ex ->
            Error ex

    let invoke4 func arg1 arg2 arg3 arg4 =
        try
            let res = func (arg1, arg2, arg3, arg4)
            Ok res
        with ex ->
            Error ex

    let invoke5 func arg1 arg2 arg3 arg4 arg5 =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5)
            Ok res
        with ex ->
            Error ex

    let invoke6 func arg1 arg2 arg3 arg4 arg5 arg6 =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6)
            Ok res
        with ex ->
            Error ex

    let invoke7 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7)
            Ok res
        with ex ->
            Error ex

    let invoke8 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
            Ok res
        with ex ->
            Error ex

    let invoke9 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
            Ok res
        with ex ->
            Error ex

    let invoke10 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
            Ok res
        with ex ->
            Error ex

    let invoke11 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)
            Ok res
        with ex ->
            Error ex

    let invoke12 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
            Ok res
        with ex ->
            Error ex

    let invoke13 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)
            Ok res
        with ex ->
            Error ex

    let invoke14 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)
            Ok res
        with ex ->
            Error ex

    let invoke15 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)
            Ok res
        with ex ->
            Error ex

    let invoke16 func arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 arg16 =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)
            Ok res
        with ex ->
            Error ex
