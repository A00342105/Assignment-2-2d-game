using UnityEngine;


[CreateAssetMenu(fileName ="NewNPCDialogue", menuName ="NPC DIALOGUE")]
public class npcdialoge : MonoBehaviour
{
    public string npcname;
    public Sprite npcportrait;
    public string[] dialoguelines;
    public bool[] autoprogresslines;
    public float autoprogressdelay = 1.5f;
    public float typingspeed = 0.05f;
 
}
