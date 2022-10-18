using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public Data data;

    public TMP_Text squirrelsText;

    private void Start()
    {
        data = new Data();
    }

    private void Update()
    {
        squirrelsText.text = data.squirrels + " Squirrels";
    }

    public void GenerateSquirrels()
    {
        data.squirrels += 1;
        data.squirrels *= 100;
        print(data.squirrels);
    }
}
