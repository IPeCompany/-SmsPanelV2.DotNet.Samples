﻿using System.ComponentModel;

namespace IPE.SmsIrSamples.DotNetCore;

public enum DeliveryState : byte
{
    [Description("نامشخص")]
    Unknown = 0,

    [Description("رسیده به گوشی")]
    Delivered = 1,

    [Description("نرسیده به گوشی")]
    Undeliverd = 2,

    [Description("پردازش در مخابرات")]
    ReachedTheOperator = 3,

    [Description("نرسیده به مخابرات")]
    NotReachedTheOperator = 4,

    [Description("رسیده به اپراتور")]
    ReachedTheProvider = 5,

    [Description("ناموفق")]
    Failed = 6,

    [Description("لیست سیاه")]
    BlackList = 7
}