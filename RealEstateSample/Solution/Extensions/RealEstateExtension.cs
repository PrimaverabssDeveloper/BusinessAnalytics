using System.ComponentModel.Composition;
using Primavera.BusinessAnalytics.Core.MEF.SolutionDeployment;
using Primavera.BusinessAnalytics.Core.Schemas;

namespace RealEstate
{
    /// <summary>
    /// RealEstate solution extension class.
    /// </summary>
    [Export(typeof(ISolutionDeploymentExtension))]
    public class RealEstateExtension : ISolutionDeploymentExtension
    {
        #region ISolutionDeploymentExtension Members

        /// <summary>
        /// Called when [before create].
        /// </summary>
        /// <param name="solutionSchema">The solution schema.</param>
        public void OnBeforeCreate(SolutionSchema solutionSchema)
        {
        }

        /// <summary>
        /// Called when [after create].
        /// </summary>
        /// <param name="solutionSchema">The solution schema.</param>
        public void OnAfterCreate(SolutionSchema solutionSchema)
        {
        }

        /// <summary>
        /// Called when [before update].
        /// </summary>
        /// <param name="currentVersion">The current version.</param>
        /// <param name="solutionSchema">The solution schema.</param>
        public void OnBeforeUpdate(string currentVersion, Primavera.BusinessAnalytics.Core.Schemas.SolutionSchema solutionSchema)
        {
        }

        /// <summary>
        /// Called when [after update].
        /// </summary>
        /// <param name="currentVersion">The current version.</param>
        /// <param name="solutionSchema">The solution schema.</param>
        public void OnAfterUpdate(string currentVersion, SolutionSchema solutionSchema)
        {
        }

        /// <summary>
        /// Called when [before delete].
        /// </summary>
        /// <param name="solutionSchema">The solution schema.</param>
        public void OnBeforeDelete(SolutionSchema solutionSchema)
        {
        }

        /// <summary>
        /// Called when [after delete].
        /// </summary>
        /// <param name="solutionSchema">The solution schema.</param>
        public void OnAfterDelete(SolutionSchema solutionSchema)
        {
        }

        #endregion
    }
}
