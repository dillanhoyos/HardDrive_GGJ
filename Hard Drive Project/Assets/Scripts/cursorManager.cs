using UnityEngine;

public class cursorManager : MonoBehaviour {

	public Texture2D cursorNormal, cursorEnBoton;
	public Vector2 cursorNormalHotSpot, cursorEnBotonHotSpot;
	
	public void OnButtonCursorEnter() {
		Cursor.SetCursor(cursorEnBoton, cursorEnBotonHotSpot, CursorMode.Auto);
	}

	public void OnButtonCursorEnter(string mensaje) {
		Cursor.SetCursor(cursorEnBoton, cursorEnBotonHotSpot, CursorMode.Auto);
		if (tooltipManager.toolTipInstance != null) {
			tooltipManager.toolTipInstance.SetAndShowTooltip(mensaje);
		}
		if (tooltipManager1.toolTipInstance != null) {
			tooltipManager1.toolTipInstance.SetAndShowTooltip(mensaje);
		}
	}

	public void OnButtonCursorExit() {
		Cursor.SetCursor(cursorNormal, cursorNormalHotSpot, CursorMode.Auto);
		if (tooltipManager.toolTipInstance != null) {
			tooltipManager.toolTipInstance.HideTooltip();
		}
		if (tooltipManager1.toolTipInstance != null) {
			tooltipManager1.toolTipInstance.HideTooltip();
		}
	}

}