using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class tooltipManager : MonoBehaviour{

	public static tooltipManager toolTipInstance;
	public TextMeshProUGUI textComponent;
	private Vector3 vectorToolTip;
	private Image imgToolTip;

	private void Awake() {
		if (toolTipInstance != null && toolTipInstance != this) {
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else {
			toolTipInstance = this;
		}
	}

	private void Start() {
		imgToolTip = GetComponent<Image>();
		vectorToolTip = Vector3.zero;
		Cursor.visible = true;
		imgToolTip.enabled = false;
		textComponent.enabled = false;
	}

	private void Update() {
		vectorToolTip.Set(UnityEngine.Input.mousePosition.x + 3f, UnityEngine.Input.mousePosition.y + 3f, 0f);
		base.transform.position = vectorToolTip;
	}

	public void SetAndShowTooltip(string mensaje) {
		imgToolTip.enabled = true;
		textComponent.enabled = true;
		textComponent.text = mensaje;
	}

	public void HideTooltip() {
		imgToolTip.enabled = false;
		textComponent.enabled = false;
		textComponent.text = string.Empty;
	}

}