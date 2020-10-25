using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Script_manager : MonoBehaviour
{
    public int maxTiles = 500;
    public bool reached = false;
    public List<Transform> tiles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
        while (tiles.Count > maxTiles)
        {
            Destroy(tiles[tiles.Count - 1].gameObject);
            tiles.RemoveAt(tiles.Count - 1);
            reached = true;
        }

        if (true)
        {
            float aX = 0f;
            float aZ = 0f;
            float maxZ = 0f;
            float minZ = 0f;
            float maxX = 0f;
            float minX = 0f;
            foreach (Transform tile in tiles)
            {
                //aX += tile.position.x;
                //aZ += tile.position.z;
                if (tile.position.z > maxZ) { maxZ = tile.position.z; }
                if (tile.position.z < minZ) { minZ = tile.position.z; }
                if (tile.position.x > maxX) { maxX = tile.position.x; }
                if (tile.position.x < minX) { minX = tile.position.x; }
            }
            aX = (maxX + minX) / 2;
            aZ = (maxZ + minZ) / 2;
            transform.position = new Vector3(aX,Mathf.Max((maxZ-minZ),(maxX-minX)),aZ);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
