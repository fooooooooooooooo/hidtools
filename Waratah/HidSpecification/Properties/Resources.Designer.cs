﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HidSpecification.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HidSpecification.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no next available id.
        /// </summary>
        internal static string ExceptionCannotFindNextAvailableUsageId {
            get {
                return ResourceManager.GetString("ExceptionCannotFindNextAvailableUsageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate name &apos;{0}&apos;.
        /// </summary>
        internal static string ExceptionDuplicatedUnitName {
            get {
                return ResourceManager.GetString("ExceptionDuplicatedUnitName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dimension BaseUnit cannot be null.
        /// </summary>
        internal static string ExceptionInvalidDimensionBaseUnitCannotBeNull {
            get {
                return ResourceManager.GetString("ExceptionInvalidDimensionBaseUnitCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exponent cannot be 0.
        /// </summary>
        internal static string ExceptionInvalidDimensionExponentIsZero {
            get {
                return ResourceManager.GetString("ExceptionInvalidDimensionExponentIsZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No overlap of Unit systems with {0}.
        /// </summary>
        internal static string ExceptionInvalidDimensionNoUnitSystemOverlap {
            get {
                return ResourceManager.GetString("ExceptionInvalidDimensionNoUnitSystemOverlap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No exponent for this Unit is valid when combining with {0}.  Cannot combine empty Units together.
        /// </summary>
        internal static string ExceptionInvalidDimensionNoValidExponent {
            get {
                return ResourceManager.GetString("ExceptionInvalidDimensionNoValidExponent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to exponent must be between {0} and {1}: actual {2}.
        /// </summary>
        internal static string ExceptionInvalidExponent {
            get {
                return ResourceManager.GetString("ExceptionInvalidExponent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} {1}.
        /// </summary>
        internal static string ExceptionInvalidExponentWithDimensionName {
            get {
                return ResourceManager.GetString("ExceptionInvalidExponentWithDimensionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transformed Usage conflicts with existing non-transformed usage &apos;{0}&apos;.
        /// </summary>
        internal static string ExceptionInvalidTransformConflictWithExistingUsageId {
            get {
                return ResourceManager.GetString("ExceptionInvalidTransformConflictWithExistingUsageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UsagePage of the transform &apos;{0}&apos; must be the same as the usage being transformed &apos;{1}&apos;.
        /// </summary>
        internal static string ExceptionInvalidTransformUsageId {
            get {
                return ResourceManager.GetString("ExceptionInvalidTransformUsageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiplier must be between {0} and {1}: actual {2}.
        /// </summary>
        internal static string ExceptionMultiplierInvalid {
            get {
                return ResourceManager.GetString("ExceptionMultiplierInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiplier &apos;{0}&apos; is not Base-10. (e.g. 1.0, 100.0, 0.0001)..
        /// </summary>
        internal static string ExceptionMultiplierNotBased10 {
            get {
                return ResourceManager.GetString("ExceptionMultiplierNotBased10", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Page for UsageStart &apos;{0}&apos; and Page for UsageEnd &apos;{1}&apos; are different..
        /// </summary>
        internal static string ExceptionRangeHasDifferentUsagePages {
            get {
                return ResourceManager.GetString("ExceptionRangeHasDifferentUsagePages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage {0}:{1} does not exist within range {2} {3}.
        /// </summary>
        internal static string ExceptionRangeUsageDoesNotExistInRange {
            get {
                return ResourceManager.GetString("ExceptionRangeUsageDoesNotExistInRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting UsageId &apos;{0}&apos; is &gt;= &apos;{1}&apos; Ending UsageId.
        /// </summary>
        internal static string ExceptionRangeUsageStartIdBiggerThanUsageEndId {
            get {
                return ResourceManager.GetString("ExceptionRangeUsageStartIdBiggerThanUsageEndId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UsageIds are the same but Names are different ({0}, {1}).  Something is terribly screwed-up.
        /// </summary>
        internal static string ExceptionUsageNamesMismatch {
            get {
                return ResourceManager.GetString("ExceptionUsageNamesMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add a Usage to the generated UsagePage &apos;{0}&apos;.
        /// </summary>
        internal static string ExceptionUsagePageCannotAddIdToGeneratedPage {
            get {
                return ResourceManager.GetString("ExceptionUsagePageCannotAddIdToGeneratedPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Id &apos;{0}&apos; matched existing UsagePage &apos;{1}&apos;, but name &apos;{2}&apos; did not.  To extend an existing UsagePage both must match.
        /// </summary>
        internal static string ExceptionUsagePageIdMatchesNameDoesnt {
            get {
                return ResourceManager.GetString("ExceptionUsagePageIdMatchesNameDoesnt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Existing UsagePage with id &apos;{0}&apos; not found.  Name may only be omitted if UsagePage with id already exists.
        /// </summary>
        internal static string ExceptionUsagePageIdNotFoundNameOmitted {
            get {
                return ResourceManager.GetString("ExceptionUsagePageIdNotFoundNameOmitted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Two distinct UsagePages matched.  Name &apos;{0}&apos; matched &apos;{1}&apos;, Id &apos;{2}&apos; matched &apos;{3}&apos;.
        /// </summary>
        internal static string ExceptionUsagePageNameAndIdMatchDifferentPages {
            get {
                return ResourceManager.GetString("ExceptionUsagePageNameAndIdMatchDifferentPages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name &apos;{0}&apos; matched existing UsagePage &apos;{1}&apos;, but id &apos;{2}&apos; did not.  To extend an existing UsagePage both must match.
        /// </summary>
        internal static string ExceptionUsagePageNameMatchesIdDoesnt {
            get {
                return ResourceManager.GetString("ExceptionUsagePageNameMatchesIdDoesnt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Existing UsagePage with name &apos;{0}&apos; not found.  Id may only be omitted if UsagePage with name already exists.
        /// </summary>
        internal static string ExceptionUsagePageNameNotFoundIdOmitted {
            get {
                return ResourceManager.GetString("ExceptionUsagePageNameNotFoundIdOmitted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Id of specified Usage &apos;{0}&apos; already exists in UsagePage &apos;{1}&apos; as &apos;{2}&apos;.  Smallest id available is &apos;{3}&apos;.
        /// </summary>
        internal static string ExceptionUsagePageUsageIdAlreadyExists {
            get {
                return ResourceManager.GetString("ExceptionUsagePageUsageIdAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name of specified Usage &apos;{0}&apos; already exists in UsagePage &apos;{1}&apos; as &apos;{2}&apos;.
        /// </summary>
        internal static string ExceptionUsagePageUsageNameAlreadyExists {
            get {
                return ResourceManager.GetString("ExceptionUsagePageUsageNameAlreadyExists", resourceCulture);
            }
        }
    }
}
