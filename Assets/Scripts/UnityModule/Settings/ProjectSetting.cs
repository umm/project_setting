using UnityEngine;

namespace UnityModule.Settings {

    /// <summary>
    /// プロジェクトの設定を司ります
    /// </summary>
    public class ProjectSetting : Setting<ProjectSetting> {

        /// <summary>
        /// プロジェクト名の実体
        /// </summary>
        [SerializeField]
        private string projectName = Application.productName;

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
        /// プロジェクトコードの実体
        /// </summary>
        [SerializeField]
        private string projectCode = Application.productName;

        /// <summary>
        /// プロジェクトコード
        /// </summary>
        public string ProjectCode {
            get {
                return this.projectCode;
            }
            set {
                this.projectCode = value;
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
        [UnityEditor.MenuItem("Assets/Create/Setting/ProjectSetting")]
        public static void CreateProjectSetting() {
            CreateAsset();
        }

#endif

    }

}
