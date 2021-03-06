﻿using Payments.Attributes;
using Payments.Wechatpay.Parameters.Requests;
using Payments.Wechatpay.Parameters.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payments.Wechatpay.Abstractions
{
    /// <summary>
    /// 提交付款码支付
    /// </summary>
    [PayService("微信付款码支付")]
    public interface IWechatpayMicroPayService : IWechatpayPayService<WechatpayMicroPayRequest, WechatpayMicroPayResponse>
    {
    }
}
