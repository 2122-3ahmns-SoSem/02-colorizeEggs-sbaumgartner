using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollSpeed;
    public bool scroll = true;

    private Material backgroundMaterial;

    private void Awake()
    {
        backgroundMaterial = GetComponent<Renderer>().material;
        Debug.Log("works");
    }

    private void FixedUpdate()
    {
        if (scroll)
        {
            Vector2 offset = new Vector2(scrollSpeed * Time.time, 0f);
            backgroundMaterial.mainTextureOffset = offset;
        }
    }
}
