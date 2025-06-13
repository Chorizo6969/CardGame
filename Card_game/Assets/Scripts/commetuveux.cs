using TMPro;
using UnityEngine;

public class Commetuveux : MonoBehaviour
{
    [SerializeField] private string _nom;
    [SerializeField] private int _test;
    [SerializeField] private TextMeshProUGUI _go;

    public void Move()
    {
        _go.text = _nom;
        return;
    }

}
