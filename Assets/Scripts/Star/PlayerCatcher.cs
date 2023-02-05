using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCatcher : MonoBehaviour
{
    [SerializeField] private float distance;
    private void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, distance);//Yıldız çevresinde distance yarı çapında çember oluşturup player var mı
        foreach (Collider collider in colliders)                              // kontrol ediyor.
        {
            if (collider.TryGetComponent<Player>(out Player player))
            {
                Star star = GetComponent<Star>();                                       
                Image InteractImg = player.InteractImg.GetComponent<Image>(); //E'ye basınca dolan image

                if (star.loadingPoint < 0.99f)              //Yıldıza yaklaşınca kırmızı çember çıkıyor
                {
                    player.Border.SetActive(true);
                }
                
                if (Input.GetKeyDown(KeyCode.E))
                {
                    AudioClip interactSound = transform.GetChild(1).GetComponent<AudioSource>().clip;
                    transform.GetChild(1).GetComponent<AudioSource>().enabled = true;
                    transform.GetChild(1).GetComponent<AudioSource>().PlayOneShot(interactSound);
                }
                
                else if (Input.GetKey(KeyCode.E))
                {
                    InteractImg.fillAmount = star.IncreaseLoadingPoint();     // Star classının içerisinde bir float var her yıldızın kendi e'ye basılı tutarken dolan float değeri var 
                    
                    
                    
                    if (InteractImg.fillAmount >= 0.99f)                      // bu sayede her yıldıza yaklaştığımda dolan çember 0lanıyor
                    {
                        distance = 0f;
                        star.state = StarState.Interacted;                    // Yıldızla etkileşime geçilip geçilmediği enum ile kontrol ediliyor.
                        player.Border.SetActive(false);                       
                        InteractImg.fillAmount = 0f;                          
                        Camera.main.GetComponent<LRRender>().SetUpLine(this.transform);    // Line çizme metodu
                        star.PlayParticle();                                  // Particleları oynatma metodu
                        GameManager.Instance.currentStar++;
                        player.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().material = gameObject.GetComponent<MeshRenderer>().material;
                        
                    }
                    
                }
                
                else if (Input.GetKeyUp(KeyCode.E))                           // Çember dolmadan elini E'den çekerse 0'lanıyor
                {
                    star.loadingPoint = 0f;                                 
                    InteractImg.fillAmount = star.loadingPoint;
                    transform.GetChild(1).GetComponent<AudioSource>().enabled = false;

                }
            }
        }

        
        
        
    }
}
