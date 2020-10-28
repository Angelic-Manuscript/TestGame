
using UnityEngine;

public class TowerButton : MonoBehaviour
{
    [SerializeField]
    GameObject towerObjec;
    [SerializeField]
    Sprite dragSprite;

    public GameObject TowerObject
    {
        get
        {
            return towerObjec;
        }
    }
    public Sprite DragSprite
    {
        get
        {
            return dragSprite;
        }
    }
}
