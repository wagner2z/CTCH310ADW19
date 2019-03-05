using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public int intel = 3;
    public bool hitOnHead = false;
    public bool readBook = false;

    float test()
    {
        return 3.0f;
    }

    void Greet()
    {
        switch (intel)
        {
            case 5:
                print("Hello good sir. Do you like physics?");
                if (hitOnHead)
                {
                    hitOnHead = false;
                    intel--;
                    Greet();
                }
                if (readBook)
                {
                    readBook = false;
                    Greet();
                }
                break;

            case 4:
                print("Ello, guv.");
                if (hitOnHead)
                {
                    hitOnHead = false;
                    intel--;
                    Greet();
                }
                if (readBook)
                {
                    readBook = false;
                    intel++;
                    Greet();
                }
                break;

            case 3:
                print("What you want?");
                if (hitOnHead)
                {
                    hitOnHead = false;
                    intel--;
                    Greet();
                }
                if (readBook)
                {
                    readBook = false;
                    intel++;
                    Greet();
                }
                break;

            case 2:
                print("Ugh, you urg.");
                if (hitOnHead)
                {
                    hitOnHead = false;
                    intel--;
                    Greet();
                }
                if (readBook)
                {
                    readBook = false;
                    intel++;
                    Greet();
                }
                break;

            case 1:
                print("Grrrrraaaaaahhhhh");
                if (hitOnHead)
                {
                    hitOnHead = false;
                    intel--;
                    Greet();
                }
                if (readBook)
                {
                    readBook = false;
                    intel++;
                    Greet();
                }
                break;

            default:
                print("*unintelligible*");
                if (hitOnHead)
                {
                    hitOnHead = false;
                    Greet();
                }
                if (readBook)
                {
                    readBook = false;
                    intel++;
                    Greet();
                }
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Greet();
        float testNum = test();
        print(testNum);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            hitOnHead = true;
            Greet();
        }

        if (Input.GetKey(KeyCode.R))
        {
            readBook = true;
            Greet();
        }

    }
}
