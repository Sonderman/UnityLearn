using UnityEngine;

public class Cube : MonoBehaviour
{
    public  MeshRenderer Renderer;
    Material _material ;
    private float _rotateAnglex;
    private float _rotateAngley;
    private float _rotateAnglez;
    void Start()
    {
        _material = Renderer.material;
        InvokeRepeating(nameof(ChangeThings),1f,3f);
    }
    
    void Update()
    {
        transform.Rotate(_rotateAnglex * Time.deltaTime, _rotateAngley * Time.deltaTime, _rotateAnglez * Time.deltaTime);
    }

    private void ChangeThings()
    {
        _rotateAnglex = Random.Range(0f, 30f);
        _rotateAngley = Random.Range(0f, 30f);
        _rotateAnglez = Random.Range(0f, 30f);
        transform.localScale = Vector3.one * Random.Range(1f, 3f);
        _material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
