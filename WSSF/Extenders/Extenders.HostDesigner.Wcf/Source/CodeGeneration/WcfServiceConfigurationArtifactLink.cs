//===============================================================================
// Microsoft patterns & practices
// Web Service Software Factory 2010
//===============================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================
using Microsoft.Practices.Modeling.CodeGeneration;
using Microsoft.Practices.Modeling.CodeGeneration.Artifacts;
using Microsoft.Practices.Modeling.CodeGeneration.Artifacts.Design;
using Microsoft.Practices.ServiceFactory.Extenders.HostDesigner.Wcf.Strategies;
using System;
using System.ComponentModel;

namespace Microsoft.Practices.ServiceFactory.Extenders.HostDesigner.Wcf.CodeGeneration
{
	[TypeConverter(typeof(ArtifactLinkConverter<WcfServiceConfigurationArtifactLink>))]
	[CodeGenerationStrategy(typeof(ServiceModelConfigurationStrategy))]
	[CLSCompliant(false)]
	public class WcfServiceConfigurationArtifactLink : ArtifactLink
	{
		public override string DefaultExtension
		{
			get
			{
				return ".config";
			}
		}
	}
}