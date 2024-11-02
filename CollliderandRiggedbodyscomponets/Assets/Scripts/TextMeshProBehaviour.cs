using UnityEngine;
using TMPro;
using System.Globalization;
[ RequireComponent(typeof(TextMeshProUGUI))]
public class TextMeshProBehaviour : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    public SimpleIntData dataObj;


    private void Start()
    {
       textObj = GetComponent<TextMeshProUGUI>();
       
    }
    
    public void Update()
    {
       UpdateWithIntData();
    }
    
    
    public void UpdateWithIntData()
    {
      textObj.text = "Score: " + dataObj.value.ToString(CultureInfo.InvariantCulture);  
    }
}
