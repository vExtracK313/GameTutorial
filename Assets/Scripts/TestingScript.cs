using System;
using UnityEngine;

public class TestingScript : MonoBehaviour
{
    int score = 5;
    void Awake() //Proje Başlatılmadan önce çalışır. eğer bir Skorun varsa Awake içine Skore=0 yazarsan oyun başlarken Skor 0 olur.
    {
        score = 0;
        Debug.Log("Awake");
    }
    void Start() //Proje Başlatıldığında çalışır. Yani sadece 1 frame çalışır
    {
        score = 0;
        Debug.Log("Start");
    }

    void Update() //Her framde çalışır
    {
        Debug.Log("Update");
    }

    void FixedUpdate() //Update'in düzenlenmiş hali eğer Update'e zıplmama komutu yazılırsa her bilgisayarda farklı çalışır ama 
    //fixedupdate te böyle olmaz. Genellikle fiziksel işlemler için kullanılır. 
    {

    }
    
    void LateUpdate() //Update ve FixedUpdate 'ten sonra çalışır ama çok az kullanılır.
    {

    }

}
