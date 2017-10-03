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
        /// プロジェクトコードの実体
        /// </summary>
        [SerializeField]
        private string projectCode;

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
            // デフォルト値を設定する
            Instance.ProjectName = Application.productName;
            Instance.ProjectCode = Application.productName;
            UnityEditor.EditorUtility.SetDirty(Instance);
        }

#endif

    }

}