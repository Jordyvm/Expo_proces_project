using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    /* Functions used to navigate between the diffrent scenes */
    #region Menu functions
    public void _idleScene()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(0).name);
    }
    public void _Gary()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(1).name);
    }

    public void _Oby()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(2).name);
    }
    public void _Dotto()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(3).name);
    }
    public void _Eind()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(4).name);
    }
    #endregion
}
