﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using XrmToolBox.Attributes;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyCompany("Microsoft Corporation and contributors")]
[assembly: AssemblyTitle("Plugin Registration Tool")]
[assembly: AssemblyDescription("Classic tool adopted to use with XrmToolBox")]
[assembly: AssemblyProduct("PluginRegistrationTool")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("163eb22a-4130-4c01-a883-29cfa0ff2631")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("2.1.0.1")]
[assembly: AssemblyFileVersion("2.1.0.1")]

[assembly: SmallImageBase64("iVBORw0KGgoAAAANSUhEUgAAAB4AAAAeCAIAAAC0Ujn1AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAYdEVYdFNvZnR3YXJlAHBhaW50Lm5ldCA0LjAuNWWFMmUAAAEfSURBVEhLY3j27BeN0KjRaGjUaDQ0OIzOb5yDJoIfkWC0vkc+mgh+RKzR9x+/ZJD3RxPEj4g1un/uJmSj56/eu//4ZTgXKyLWaHmrFLjRQB8AudQxGuhGoLlwo+v7lwPZcKPjiyZCGGiIKKPtw6rgRp+/eg/ChhgNNBcijokIGw13MhABQxyYTiDszXtO+6e0QdhoWiCIgNGQYIXoByJIZGKy0XRBEAGjgdkErh+IqGb0+p0n4JohiDpGA4OCXycSrhmIBHSjqGM0JLqAAR2S2ZlQPBGY4ICB4xBeDUSQ0CfTaKC5cpYpzZNWJpdNdo2phxsKQcC0CETw5EGa0Ss3H0ETwYqA6RLoIWBAoYlDEL5opBCNGo2GRo1GQc9+AQASPtXkak6ubgAAAABJRU5ErkJggg==")]
[assembly: BigImageBase64("iVBORw0KGgoAAAANSUhEUgAAAFAAAABQCAIAAAABc2X6AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAYdEVYdFNvZnR3YXJlAHBhaW50Lm5ldCA0LjAuNWWFMmUAAAQ8SURBVHhe7ZrfccMwCMa9Tx89S1fwHFkjK3SWvHaFDtGXFD5AQuSPnNR2Wll333EKRjY/geSk1+Hr63tX6sCtqwO3rg7cujpw6+rArasDt64O3Lo6cOvqwOvr+HGaDsfg3EwvACba8X0Kzs30AuDxfWfAw9u4N+BpfNsNMG3gYZh2VGFC5QrvB5hodwRMb2A6sWa2NL+u35d/XW8KzP08UIXplK6TSPMH5++1KTD6eW6FV+r87YCPdD5jA895D1MzD8Mqr+vtgKVFCYNLV+tVboR/XWE+roA6h4R2uCzNnK3+qDYCBgPv3jl7WMP+dYUFQCt8F5i6XYNn7GFqnOCpagtgPoEAkOwtEn1R18JEHPY2BmdVWwBLZtne3pypmSX4zh6W+5AN/qpWB5ZfC4zB9l7pyCmcKf5WhXEfDQ6XqlodWBm8vUaib2lpe4m8tofR8xIgMX+swpe791aF+ZKuiC5KLUwbIQRUtSKwnUCWn4MJJHrJrwvifdjx42LtEJMCZmpFYEpXiiDl8rl6ksl9A9N1sVkpLHxvMcuz0n1mai3g/IKJWRYkONLcVUG1jxJWxFysndxnvtYCHri8Oa3CJpJctwQjH3VMR4CrbZpeWP/QOVoFONZNbOIZmITCckxE1cF4OJ5SpxTB9vGPnNKWfU4rJE0roi+YhHEtjBrh+EkVpvFFjNnw6KqWB8aX4ZKkxKCki9L5S3nMA21p9l/rAkSGp1e1MDA3s+SUM/O56oBOZi4dJ50ulUiw9NXyxBV2c1OMrVFIoKqFgXMqAVI+mrWW1qThdwODIeAcdh37pRWmLad5JJs5i0vjYUJLZ7bMIBZ+uiEqTM7Cnz++sML4FhlLlK14zPLm5Ja2gERbTry+h8tbhTSqWgZY04pVwiA4MaCWtgoX/uxhyxW2U9pdSpGwIZOqlgFGNpKEDXytMoPaYnOWl9wsX+HshM3xIZOqFgDmrevxgg0Y8HCF5ZS+ESBjt4fF6WLMhmSq+i0waC0Vn5kvBVKnqsrhTL97Tp9n/vXjGfxc8dxrhHT/bSuMt64+GDmlAVuCBKFAMid9ZOE/ADS+mO7GYOP3cAK+jME4pFTV88D8Nwq/2JKKcFIxifPA/7zCtZUKw0qAEwIgvoQ72K0IeEKF0yMCNg9CVlU9CVx0GqzwaA2FEzw0ZnKpswwsRgbwpy5AI5B4IdiZt3q2DnuzLx75qbACxrKBYMADckkUKbq5yaMAWDW9CZGfz2frI7+BMy3ZkFhVDwPzYcPP0wf7qoocnsaw4ExldxbK8TIFs7SM4iltqvAGe9g9D3sVhPJnmoRETjmrwtw5ksYuFi62AwbmCdOregoYzxM2wQPhM3hzJPykjKrkPA7BVT0DbDVci/COrPgGv8GhRc8LnleJ1p02TnBW9TDwf1cHbl0duHV14NbVgVtXB25dHbh1deDW1YHb1tf3D1cRAm+TdeTLAAAAAElFTkSuQmCC")]

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]