using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    [SerializeField] private float ScrollSpeed;
    [SerializeField] private Renderer backgroundRenderer;

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(ScrollSpeed * Time.deltaTime, 0f);
    }
}
