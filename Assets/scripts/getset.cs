using TMPro.EditorUtilities;
using UnityEngine;

public class getset : MonoBehaviour
{
    private Player player = new Player();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player.power = 200;
        Debug.Log(player.getPower());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public class Player
    {
        private int _power;
        public int power
        {
            set { _power = value; }
            get {  return _power; }
        }
        public int getPower()
        {
            return power;
        }
    }
}
