﻿using Payments.Attributes;
using Payments.Core.Enum;
using Payments.Wechatpay.Parameters.Requests;
using Payments.Wechatpay.Parameters.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payments.Wechatpay.Abstractions
{
    /// <summary>
    /// 微信Native支付服务
    /// </summary>
    [PayService("微信Native支付", PayOriginType.WechatPay)]
    public interface IWechatpayNativePayService : IWechatpayPayService<WechatpayNativePayRequest, WechatpayNativePayResponse>
    {

    }
}
