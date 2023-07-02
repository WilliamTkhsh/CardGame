using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    public Vector3 targetScale;
    public float scalingSpeed = 1f;

    private Vector3 initialScale;
    private bool isScaling = false;

    private void Awake()
    {
        initialScale = transform.localScale;
        StartScaling();
    }

    private void Update()
    {
        if (isScaling)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, targetScale, scalingSpeed * Time.deltaTime);

            // Verificar se o objeto atingiu o tamanho desejado
            if (Vector3.Distance(transform.localScale, targetScale) < 0.01f)
            {
                isScaling = false;
                Debug.Log("Objeto atingiu o tamanho desejado!");
            }
        }
    }

    public void StartScaling()
    {
        isScaling = true;
        transform.localScale = initialScale;
    }
}
