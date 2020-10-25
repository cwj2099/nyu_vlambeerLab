using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_tile : MonoBehaviour
{
    public Texture2D t1;
    public Texture2D t2;
    public Texture2D t3;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Material>().SetTexture("_MainTex", t2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
