﻿// # Copyright © 2012, Arnold Zokas
// # All rights reserved. 

using Machine.Specifications;
using MvcNavigation.Sitemap;

namespace MvcNavigation.Specifications.SitemapSpecs
{
	[Subject(typeof(XmlSitemapResult))]
	public class when_initialised
	{
		static XmlSitemapResult xml_sitemap_result;

		Because of = () => xml_sitemap_result = new XmlSitemapResult(null);

		It should_set_content_type_to_application_xml = () => xml_sitemap_result.ContentType.ShouldEqual("application/xml");
	}
}