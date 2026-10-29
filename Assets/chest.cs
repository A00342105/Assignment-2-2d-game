using System.Diagnostics.Contracts;
using UnityEngine;

public class chest : MonoBehaviour, IInteractable
{
    public bool isopened { get; private set; }
    public string chestID { get; private set; }
    public GameObject itemprefab;
    public Sprite openedSprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chestID  ??= globalhelper.GenerateUniqueID(gameObject);
    }


    public bool caninteract()
    {
        return !isopened;
    }

    public void interact()
    {
        if (!caninteract()) return;

    }

    private void openchest()
    {

        setOpened(true);

        if (itemprefab)
        {
            GameObject droppeditem = Instantiate(itemprefab, transform.position + Vector3.down, Quaternion.identity);
            
        }

    }
    public void setOpened(bool opened)
    {
        
        if (isopened = opened)
        {
            GetComponent<SpriteRenderer>().sprite = openedSprite;
        }
    }
}
