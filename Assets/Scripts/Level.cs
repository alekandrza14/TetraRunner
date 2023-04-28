using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;


    public static class Level
    {
        public static void Restart()
        {
            SceneManager.LoadScene(0);
        }
    }

