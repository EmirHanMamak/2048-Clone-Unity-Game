using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public TileState state { get; private set;}
    public TileCell cell { get; private set; }
    public int number {get; private set; }
    private Image background;
    private TextMeshProUGUI text;

    private void Awake() {
        background = GetComponent<Image>();
        text = GetComponentInChildren<TextMeshProUGUI>();
}
    public void SetState(TileState state, int number) {
       
        this.state = state;
        switch (number)
        {
            case 2:
            background.color = Color.blue;
            text.color = Color.white;
            break;
            case 4:
            background.color = Color.cyan;
            text.color = Color.white;
            break;
            case 8:
            background.color = Color.magenta;
            text.color = Color.white;
            break;
            case 16:
            background.color = Color.green;
            text.color = Color.white;
            break;
            case 32:
            background.color = Color.HSVToRGB(128 ,250, 25);
            text.color = Color.white;
            break;
            case 64:
            background.color = Color.black;
            text.color = Color.white;
            break;
            case 128:
            background.color = Color.blue;
            text.color = Color.white;
            break;
            case 256:
            background.color = Color.blue;
            text.color = Color.white;
            break;
            case 512:
            background.color = Color.blue;
            text.color = Color.white;
            break;
            case 1024:
            background.color = Color.blue;
            text.color = Color.white;
            break;
            case 2048:
            background.color = Color.blue;
            text.color = Color.white;
            break;
            case 4096:
            background.color = Color.blue;
            text.color = Color.white;
            break;
            
            default:
            break;
        }

        text.text = number.ToString();
    }
    public void Spawn(TileCell cell) {
        if(this.cell != null) {
            this.cell.tile = null;
        }
        this.cell = cell;
        this.cell.tile = this;
        transform.position = cell.transform.position;
    }
}
