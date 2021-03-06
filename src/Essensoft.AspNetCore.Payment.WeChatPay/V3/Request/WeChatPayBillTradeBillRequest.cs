﻿using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - 申请交易账单API（电商平台、服务商、直连商户）
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_6.shtml">JSAPI支付 - 申请交易账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_6.shtml">APP支付 - 申请交易账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_6.shtml">H5支付 - 申请交易账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_6.shtml">Native支付 - 申请交易账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_6.shtml">小程序支付 - 申请交易账单API</a></para>
    /// 最新更新时间：2019.09.16
    /// </summary>
    public class WeChatPayBillTradeBillRequest : IWeChatPayGetRequest<WeChatPayBillTradeBillResponse>
    {
        private WeChatPayObject queryModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/bill/tradebill";
        }

        public WeChatPayObject GetQueryModel()
        {
            return queryModel;
        }

        public void SetQueryModel(WeChatPayObject queryModel)
        {
            this.queryModel = queryModel;
        }
    }
}
