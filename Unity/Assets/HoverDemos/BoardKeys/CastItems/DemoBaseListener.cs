﻿namespace HoverDemos.BoardKeys.CastItems {

	/*================================================================================================* /
	public abstract class DemoBaseListener<T> : HovercastItemListener<T> where T : ISelectableItem {

		protected DemoEnvironment Enviro { get; private set; }
		protected HoverboardSetup HoverboardSetup { get; private set; }
		protected ItemPanel[] ItemPanels { get; private set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------* /
		protected override void Setup() {
			Enviro = GameObject.Find("DemoEnvironment").GetComponent<DemoEnvironment>();
			HoverboardSetup = GameObject.Find("Hoverboard").GetComponent<HoverboardSetup>();

			ItemPanels = HoverboardSetup.Panels
				.Select(x => x.GetPanel())
				.ToArray();
		}

	}*/

}
