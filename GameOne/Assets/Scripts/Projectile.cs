using UnityEngine;

public enum projectileType
{
    rock, arrow, fireball
};
public class Projectile : MonoBehaviour
{
    [SerializeField]
    int attacDamage;
    [SerializeField]
    projectileType pType;

    public int AttacDamage
    {
        get
        {
            return attacDamage;
        }
    }
    public projectileType PType 
    {
        get
        {
            return pType;
        }
    }
}
