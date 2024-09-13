namespace Foo

type Result<'T> = Result<'T, System.Exception>

type 'T result = Result<'T>

module Func =
    let invoke<'T, 'TResult> (func: 'T -> 'TResult) arg : 'TResult result =
        try
            let res = func arg
            Ok res
        with ex ->
            Error ex

    let invoke2<'T1, 'T2, 'TResult> (func: 'T1 * 'T2 -> 'TResult) arg1 arg2 : 'TResult result =
        try
            let res = func (arg1, arg2)
            Ok res
        with ex ->
            Error ex

    let invoke3<'T1, 'T2, 'T3, 'TResult> (func: 'T1 * 'T2 * 'T3 -> 'TResult) arg1 arg2 arg3 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3)
            Ok res
        with ex ->
            Error ex

    let invoke4<'T1, 'T2, 'T3, 'T4, 'TResult> (func: 'T1 * 'T2 * 'T3 * 'T4 -> 'TResult) arg1 arg2 arg3 arg4 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3, arg4)
            Ok res
        with ex ->
            Error ex

    let invoke5<'T1, 'T2, 'T3, 'T4, 'T5, 'TResult> (func: 'T1 * 'T2 * 'T3 * 'T4 * 'T5 -> 'TResult) arg1 arg2 arg3 arg4 arg5 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5)
            Ok res
        with ex ->
            Error ex

    let invoke6<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TResult> (func: 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 -> 'TResult) arg1 arg2 arg3 arg4 arg5 arg6 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6)
            Ok res
        with ex ->
            Error ex

    let invoke7<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TResult> (func: 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 -> 'TResult) arg1 arg2 arg3 arg4 arg5 arg6 arg7 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7)
            Ok res
        with ex ->
            Error ex

    let invoke8<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TResult> (func: 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 -> 'TResult) arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
            Ok res
        with ex ->
            Error ex

    let invoke9<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TResult> (func: 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 -> 'TResult) arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
            Ok res
        with ex ->
            Error ex

    let invoke10<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TResult> (func: 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 -> 'TResult) arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
            Ok res
        with ex ->
            Error ex

    let invoke11<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TResult> (func: 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 -> 'TResult) arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)
            Ok res
        with ex ->
            Error ex

    let invoke12<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TResult> (func: 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 -> 'TResult) arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
            Ok res
        with ex ->
            Error ex

    let invoke13<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TResult> (func: 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 -> 'TResult) arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)
            Ok res
        with ex ->
            Error ex

    let invoke14<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TResult> (func: 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 -> 'TResult) arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)
            Ok res
        with ex ->
            Error ex

    let invoke15<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TResult> (func: 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 -> 'TResult) arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)
            Ok res
        with ex ->
            Error ex

    let invoke16<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TResult> (func: 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10 * 'T11 * 'T12 * 'T13 * 'T14 * 'T15 * 'T16 -> 'TResult) arg1 arg2 arg3 arg4 arg5 arg6 arg7 arg8 arg9 arg10 arg11 arg12 arg13 arg14 arg15 arg16 : 'TResult result =
        try
            let res = func (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)
            Ok res
        with ex ->
            Error ex
