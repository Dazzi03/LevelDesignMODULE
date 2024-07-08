using UnityEngine;
using UnityEngine.UI;

public class RandomColor : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] float time = .5f;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= time)
        {
            timer = 0;
            image.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
