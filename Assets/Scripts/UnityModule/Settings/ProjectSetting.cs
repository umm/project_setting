using UnityEngine;

namespace UnityModule.Settings {

    /// <summary>
    /// プロジェクトの設定を司ります
    /// </summary>
    public class ProjectSetting : PrioritizeSetting<ProjectSetting> {

        /// <summary>
        /// プロジェクト名の実体
        /// </summary>
        [SerializeField]
        private string projectName;

        /// <summary>
        /// プロジェクト名
        /// </summary>
        public string ProjectName {
            get {
                return this.projectName;
            }
            set {
                this.projectName = value;
            }
        }

        /// <summary>
        /// メインプロジェクトかどうかの実体
        /// </summary>
        [SerializeField]
        private bool isMain;

        /// <summary>
        /// メインプロジェクトかどうか
        /// </summary>
        public bool IsMain {
            get {
                return this.isMain;
            }
            set {
                this.isMain = value;
            }
        }

#if UNITY_EDITOR

        /// <summary>
        /// プロジェクト設定アセットを生成する
        /// </summary>
        [UnityEditor.MenuItem("Assets/Create/Setting/Create ProjectSetting")]
        public static void CreateProjectSetting() {
            CreateAsset();
        }

#endif

    }

}