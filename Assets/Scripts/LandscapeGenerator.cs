using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandscapeGenerator : MonoBehaviour
{
    public GameObject tile;
    public new Camera camera;

    public void generateLandscape()
    {
        Vector3 startingPoint = camera.ViewportToWorldPoint(new Vector3(0, 0, camera.nearClipPlane));
        Vector3 rightEdge = camera.ViewportToWorldPoint(new Vector3(1, 0, camera.nearClipPlane));
        Vector3 upperEdge = camera.ViewportToWorldPoint(new Vector3(0, 0.5f, camera.nearClipPlane));
        Vector3 tileSetPoint = startingPoint;
        GameObject terrain = new GameObject("Terrain");

        while (tileSetPoint.y < upperEdge.y)
        {
            
            while (tileSetPoint.x < (rightEdge.x + tile.transform.localScale.x))
            {
                Instantiate(tile, tileSetPoint, tile.transform.rotation, terrain.transform);
                tileSetPoint.x += tile.transform.localScale.x;
            }

            tileSetPoint.x = startingPoint.x;
            tileSetPoint.y += tile.transform.localScale.y;

        }
    }
}
