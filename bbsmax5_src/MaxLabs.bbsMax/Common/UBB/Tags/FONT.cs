﻿//
// 请注意：bbsmax 不是一个免费产品，源代码仅限用于学习，禁止用于商业站点或者其他商业用途
// 如果您要将bbsmax用于商业用途，需要从官方购买商业授权，得到授权后可以基于源代码二次开发
//
// 版权所有 厦门麦斯网络科技有限公司
// 公司网站 www.bbsmax.com
//

/*
 * 创建者: 达达
 * 创建时间: 2008-3-24 9:25
 * 版权归属: MaxLab.
 */

using System;
using System.Web.UI;

namespace MaxLabs.bbsMax.Ubb {
	/// <summary>
	/// [FONT=font_name]text[/FONT]
	/// </summary>
	public class FONT : UbbTagHandler {
		
		public override string UbbTagName {
			get { return "font"; }
		}
		
		public override string HtmlTagName {
			get { return "font"; }
		}
		
		public override UbbTagHandler GetInstance {
			get { return this; }
		}

        public override string BuildHtml(UbbParser parser, string param, string content)
        {
            return base.BuildHtml(parser, param, content);
        }

        protected override void BuildAttribute(HtmlTextWriter writer, string param, string content)
		{
			writer.WriteAttribute("face", param);
		}
	}
}