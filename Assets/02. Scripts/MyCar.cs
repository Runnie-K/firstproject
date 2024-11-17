using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class MyCar : Car
{
    // Start is called before the first frame update
    void Start()
    {
        company = "KIA";
        print(company);
        year = 2024;
        print(year);
        model = "n1";
        print(model);
        accident = false;
        print(accident);
        maxspeed = 240;
        print(maxspeed+"Km/h");
        auto = true;
        print(auto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
