﻿using System;
using Henu.Navigation;

namespace Henu.Settings {

	/*================================================================================================*/
	public interface ISettings {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		Type GetUiArcSegmentRendererType(NavItem pNavItem);

		/*--------------------------------------------------------------------------------------------*/
		Type GetUiCursorRendererType();

		/*--------------------------------------------------------------------------------------------*/
		ArcSegmentSettings GetArcSegmentSettings(NavItem pNavItem);

		/*--------------------------------------------------------------------------------------------*/
		InteractionSettings GetInteractionSettings();

	}

}