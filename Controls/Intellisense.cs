using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CefSharp;
using CefSharp.WinForms;

namespace Controls
{
	internal class Intellisense
	{
		public static Dictionary<string, string[]> DOCKWIDGETPLUGINGUIINFO = new Dictionary<string, string[]>
		{
			{
				"DockWidgetPluginGuiInfo",
				new string[3] { "Class", "", "DockWidgetPluginGuiInfo" }
			},
			{
				"DockWidgetPluginGuiInfo.new",
				new string[3] { "Method", "", "DockWidgetPluginGuiInfo.new" }
			}
		};

		public static Dictionary<string, string[]> OS = new Dictionary<string, string[]>
		{
			{
				"os",
				new string[3] { "Class", "", "os" }
			},
			{
				"os.clock",
				new string[3] { "Method", "", "os.clock" }
			},
			{
				"os.difftime",
				new string[3] { "Method", "", "os.difftime" }
			},
			{
				"os.time",
				new string[3] { "Method", "", "os.time" }
			},
			{
				"os.date",
				new string[3] { "Method", "", "os.date" }
			}
		};

		public static Dictionary<string, string[]> UDIM = new Dictionary<string, string[]>
		{
			{
				"UDim",
				new string[3] { "Class", "", "UDim" }
			},
			{
				"UDim.new",
				new string[3] { "Method", "", "UDim.new" }
			}
		};

		public static Dictionary<string, string[]> DEBUG = new Dictionary<string, string[]>
		{
			{
				"debug",
				new string[3] { "Class", "", "debug" }
			},
			{
				"debug.getupvalue",
				new string[3] { "Method", "", "debug.getupvalue" }
			},
			{
				"debug.getconstant",
				new string[3] { "Method", "", "debug.getconstant" }
			},
			{
				"debug.getproto",
				new string[3] { "Method", "", "debug.getproto" }
			},
			{
				"debug.profileend",
				new string[3] { "Method", "", "debug.profileend" }
			},
			{
				"debug.profilebegin",
				new string[3] { "Method", "", "debug.profilebegin" }
			},
			{
				"debug.getprotos",
				new string[3] { "Method", "", "debug.getprotos" }
			},
			{
				"debug.traceback",
				new string[3] { "Method", "", "debug.traceback" }
			},
			{
				"debug.getconstants",
				new string[3] { "Method", "", "debug.getconstants" }
			},
			{
				"debug.getinfo",
				new string[3] { "Method", "", "debug.getinfo" }
			},
			{
				"debug.setupvalue",
				new string[3] { "Method", "", "debug.setupvalue" }
			},
			{
				"debug.setconstant",
				new string[3] { "Method", "", "debug.setconstant" }
			},
			{
				"debug.getregistry",
				new string[3] { "Method", "", "debug.getregistry" }
			},
			{
				"debug.getupvalues",
				new string[3] { "Method", "", "debug.getupvalues" }
			}
		};

		public static Dictionary<string, string[]> COROUTINE = new Dictionary<string, string[]>
		{
			{
				"coroutine",
				new string[3] { "Class", "", "coroutine" }
			},
			{
				"coroutine.resume",
				new string[3] { "Method", "", "coroutine.resume" }
			},
			{
				"coroutine.yield",
				new string[3] { "Method", "", "coroutine.yield" }
			},
			{
				"coroutine.running",
				new string[3] { "Method", "", "coroutine.running" }
			},
			{
				"coroutine.status",
				new string[3] { "Method", "", "coroutine.status" }
			},
			{
				"coroutine.wrap",
				new string[3] { "Method", "", "coroutine.wrap" }
			},
			{
				"coroutine.create",
				new string[3] { "Method", "", "coroutine.create" }
			},
			{
				"coroutine.isyieldable",
				new string[3] { "Method", "", "coroutine.isyieldable" }
			}
		};

		public static Dictionary<string, string[]> SHARED = new Dictionary<string, string[]> { 
		{
			"shared",
			new string[3] { "Class", "", "shared" }
		} };

		public static Dictionary<string, string[]> PLUGINDRAG = new Dictionary<string, string[]>
		{
			{
				"PluginDrag",
				new string[3] { "Class", "", "PluginDrag" }
			},
			{
				"PluginDrag.new",
				new string[3] { "Method", "", "PluginDrag.new" }
			}
		};

		public static Dictionary<string, string[]> RAYCASTPARAMS = new Dictionary<string, string[]>
		{
			{
				"RaycastParams",
				new string[3] { "Class", "", "RaycastParams" }
			},
			{
				"RaycastParams.new",
				new string[3] { "Method", "", "RaycastParams.new" }
			}
		};

		public static Dictionary<string, string[]> TABLE = new Dictionary<string, string[]>
		{
			{
				"table",
				new string[3] { "Class", "", "table" }
			},
			{
				"table.pack",
				new string[3] { "Method", "", "table.pack" }
			},
			{
				"table.move",
				new string[3] { "Method", "", "table.move" }
			},
			{
				"table.insert",
				new string[3] { "Method", "", "table.insert" }
			},
			{
				"table.getn",
				new string[3] { "Method", "", "table.getn" }
			},
			{
				"table.foreachi",
				new string[3] { "Method", "", "table.foreachi" }
			},
			{
				"table.maxn",
				new string[3] { "Method", "", "table.maxn" }
			},
			{
				"table.foreach",
				new string[3] { "Method", "", "table.foreach" }
			},
			{
				"table.concat",
				new string[3] { "Method", "", "table.concat" }
			},
			{
				"table.unpack",
				new string[3] { "Method", "", "table.unpack" }
			},
			{
				"table.find",
				new string[3] { "Method", "", "table.find" }
			},
			{
				"table.create",
				new string[3] { "Method", "", "table.create" }
			},
			{
				"table.sort",
				new string[3] { "Method", "", "table.sort" }
			},
			{
				"table.remove",
				new string[3] { "Method", "", "table.remove" }
			}
		};

		public static Dictionary<string, string[]> TWEENINFO = new Dictionary<string, string[]>
		{
			{
				"TweenInfo",
				new string[3] { "Class", "", "TweenInfo" }
			},
			{
				"TweenInfo.new",
				new string[3] { "Method", "", "TweenInfo.new" }
			}
		};

		public static Dictionary<string, string[]> VECTOR3 = new Dictionary<string, string[]>
		{
			{
				"Vector3",
				new string[3] { "Class", "", "Vector3" }
			},
			{
				"Vector3.FromNormalId",
				new string[3] { "Method", "", "Vector3.FromNormalId" }
			},
			{
				"Vector3.FromAxis",
				new string[3] { "Method", "", "Vector3.FromAxis" }
			},
			{
				"Vector3.fromAxis",
				new string[3] { "Method", "", "Vector3.fromAxis" }
			},
			{
				"Vector3.fromNormalId",
				new string[3] { "Method", "", "Vector3.fromNormalId" }
			},
			{
				"Vector3.new",
				new string[3] { "Method", "", "Vector3.new" }
			}
		};

		public static Dictionary<string, string[]> VECTOR2INT16 = new Dictionary<string, string[]>
		{
			{
				"Vector2int16",
				new string[3] { "Class", "", "Vector2int16" }
			},
			{
				"Vector2int16.new",
				new string[3] { "Method", "", "Vector2int16.new" }
			}
		};

		public static Dictionary<string, string[]> FACES = new Dictionary<string, string[]>
		{
			{
				"Faces",
				new string[3] { "Class", "", "Faces" }
			},
			{
				"Faces.new",
				new string[3] { "Method", "", "Faces.new" }
			}
		};

		public static Dictionary<string, string[]> REGION3 = new Dictionary<string, string[]>
		{
			{
				"Region3",
				new string[3] { "Class", "", "Region3" }
			},
			{
				"Region3.new",
				new string[3] { "Method", "", "Region3.new" }
			}
		};

		public static Dictionary<string, string[]> MATH = new Dictionary<string, string[]>
		{
			{
				"math",
				new string[3] { "Class", "", "math" }
			},
			{
				"math.log",
				new string[3] { "Method", "", "math.log" }
			},
			{
				"math.ldexp",
				new string[3] { "Method", "", "math.ldexp" }
			},
			{
				"math.rad",
				new string[3] { "Method", "", "math.rad" }
			},
			{
				"math.cosh",
				new string[3] { "Method", "", "math.cosh" }
			},
			{
				"math.random",
				new string[3] { "Method", "", "math.random" }
			},
			{
				"math.frexp",
				new string[3] { "Method", "", "math.frexp" }
			},
			{
				"math.tanh",
				new string[3] { "Method", "", "math.tanh" }
			},
			{
				"math.floor",
				new string[3] { "Method", "", "math.floor" }
			},
			{
				"math.max",
				new string[3] { "Method", "", "math.max" }
			},
			{
				"math.sqrt",
				new string[3] { "Method", "", "math.sqrt" }
			},
			{
				"math.modf",
				new string[3] { "Method", "", "math.modf" }
			},
			{
				"math.pow",
				new string[3] { "Method", "", "math.pow" }
			},
			{
				"math.atan",
				new string[3] { "Method", "", "math.atan" }
			},
			{
				"math.tan",
				new string[3] { "Method", "", "math.tan" }
			},
			{
				"math.cos",
				new string[3] { "Method", "", "math.cos" }
			},
			{
				"math.sign",
				new string[3] { "Method", "", "math.sign" }
			},
			{
				"math.clamp",
				new string[3] { "Method", "", "math.clamp" }
			},
			{
				"math.log10",
				new string[3] { "Method", "", "math.log10" }
			},
			{
				"math.noise",
				new string[3] { "Method", "", "math.noise" }
			},
			{
				"math.acos",
				new string[3] { "Method", "", "math.acos" }
			},
			{
				"math.abs",
				new string[3] { "Method", "", "math.abs" }
			},
			{
				"math.sinh",
				new string[3] { "Method", "", "math.sinh" }
			},
			{
				"math.asin",
				new string[3] { "Method", "", "math.asin" }
			},
			{
				"math.min",
				new string[3] { "Method", "", "math.min" }
			},
			{
				"math.deg",
				new string[3] { "Method", "", "math.deg" }
			},
			{
				"math.fmod",
				new string[3] { "Method", "", "math.fmod" }
			},
			{
				"math.randomseed",
				new string[3] { "Method", "", "math.randomseed" }
			},
			{
				"math.atan2",
				new string[3] { "Method", "", "math.atan2" }
			},
			{
				"math.ceil",
				new string[3] { "Method", "", "math.ceil" }
			},
			{
				"math.sin",
				new string[3] { "Method", "", "math.sin" }
			},
			{
				"math.exp",
				new string[3] { "Method", "", "math.exp" }
			}
		};

		public static Dictionary<string, string[]> RANDOM = new Dictionary<string, string[]>
		{
			{
				"Random",
				new string[3] { "Class", "", "Random" }
			},
			{
				"Random.new",
				new string[3] { "Method", "", "Random.new" }
			}
		};

		public static Dictionary<string, string[]> AXES = new Dictionary<string, string[]>
		{
			{
				"Axes",
				new string[3] { "Class", "", "Axes" }
			},
			{
				"Axes.new",
				new string[3] { "Method", "", "Axes.new" }
			}
		};

		public static Dictionary<string, string[]> COLORSEQUENCEKEYPOINT = new Dictionary<string, string[]>
		{
			{
				"ColorSequenceKeypoint",
				new string[3] { "Class", "", "ColorSequenceKeypoint" }
			},
			{
				"ColorSequenceKeypoint.new",
				new string[3] { "Method", "", "ColorSequenceKeypoint.new" }
			}
		};

		public static Dictionary<string, string[]> CFRAME = new Dictionary<string, string[]>
		{
			{
				"CFrame",
				new string[3] { "Class", "", "CFrame" }
			},
			{
				"CFrame.fromMatrix",
				new string[3] { "Method", "", "CFrame.fromMatrix" }
			},
			{
				"CFrame.fromAxisAngle",
				new string[3] { "Method", "", "CFrame.fromAxisAngle" }
			},
			{
				"CFrame.fromOrientation",
				new string[3] { "Method", "", "CFrame.fromOrientation" }
			},
			{
				"CFrame.fromEulerAnglesXYZ",
				new string[3] { "Method", "", "CFrame.fromEulerAnglesXYZ" }
			},
			{
				"CFrame.Angles",
				new string[3] { "Method", "", "CFrame.Angles" }
			},
			{
				"CFrame.fromEulerAnglesYXZ",
				new string[3] { "Method", "", "CFrame.fromEulerAnglesYXZ" }
			},
			{
				"CFrame.new",
				new string[3] { "Method", "", "CFrame.new" }
			}
		};

		public static Dictionary<string, string[]> DATETIME = new Dictionary<string, string[]>
		{
			{
				"DateTime",
				new string[3] { "Class", "", "DateTime" }
			},
			{
				"DateTime.fromUnixTimestamp",
				new string[3] { "Method", "", "DateTime.fromUnixTimestamp" }
			},
			{
				"DateTime.now",
				new string[3] { "Method", "", "DateTime.now" }
			},
			{
				"DateTime.fromIsoDate",
				new string[3] { "Method", "", "DateTime.fromIsoDate" }
			},
			{
				"DateTime.fromUnixTimestampMillis",
				new string[3] { "Method", "", "DateTime.fromUnixTimestampMillis" }
			},
			{
				"DateTime.fromLocalTime",
				new string[3] { "Method", "", "DateTime.fromLocalTime" }
			},
			{
				"DateTime.fromUniversalTime",
				new string[3] { "Method", "", "DateTime.fromUniversalTime" }
			}
		};

		public static Dictionary<string, string[]> COLOR3 = new Dictionary<string, string[]>
		{
			{
				"Color3",
				new string[3] { "Class", "", "Color3" }
			},
			{
				"Color3.fromHSV",
				new string[3] { "Method", "", "Color3.fromHSV" }
			},
			{
				"Color3.toHSV",
				new string[3] { "Method", "", "Color3.toHSV" }
			},
			{
				"Color3.fromRGB",
				new string[3] { "Method", "", "Color3.fromRGB" }
			},
			{
				"Color3.new",
				new string[3] { "Method", "", "Color3.new" }
			}
		};

		public static Dictionary<string, string[]> ENUM = new Dictionary<string, string[]>();

		public static Dictionary<string, string[]> _G = new Dictionary<string, string[]> { 
		{
			"_G",
			new string[3] { "Class", "", "_G" }
		} };

		public static Dictionary<string, string[]> NUMBERRANGE = new Dictionary<string, string[]>
		{
			{
				"NumberRange",
				new string[3] { "Class", "", "NumberRange" }
			},
			{
				"NumberRange.new",
				new string[3] { "Method", "", "NumberRange.new" }
			}
		};

		public static Dictionary<string, string[]> PHYSICALPROPERTIES = new Dictionary<string, string[]>
		{
			{
				"PhysicalProperties",
				new string[3] { "Class", "", "PhysicalProperties" }
			},
			{
				"PhysicalProperties.new",
				new string[3] { "Method", "", "PhysicalProperties.new" }
			}
		};

		public static Dictionary<string, string[]> RAY = new Dictionary<string, string[]>
		{
			{
				"Ray",
				new string[3] { "Class", "", "Ray" }
			},
			{
				"Ray.new",
				new string[3] { "Method", "", "Ray.new" }
			}
		};

		public static Dictionary<string, string[]> NUMBERSEQUENCEKEYPOINT = new Dictionary<string, string[]>
		{
			{
				"NumberSequenceKeypoint",
				new string[3] { "Class", "", "NumberSequenceKeypoint" }
			},
			{
				"NumberSequenceKeypoint.new",
				new string[3] { "Method", "", "NumberSequenceKeypoint.new" }
			}
		};

		public static Dictionary<string, string[]> VECTOR2 = new Dictionary<string, string[]>
		{
			{
				"Vector2",
				new string[3] { "Class", "", "Vector2" }
			},
			{
				"Vector2.new",
				new string[3] { "Method", "", "Vector2.new" }
			}
		};

		public static Dictionary<string, string[]> CELLID = new Dictionary<string, string[]>
		{
			{
				"CellId",
				new string[3] { "Class", "", "CellId" }
			},
			{
				"CellId.new",
				new string[3] { "Method", "", "CellId.new" }
			}
		};

		public static Dictionary<string, string[]> VECTOR3INT16 = new Dictionary<string, string[]>
		{
			{
				"Vector3int16",
				new string[3] { "Class", "", "Vector3int16" }
			},
			{
				"Vector3int16.new",
				new string[3] { "Method", "", "Vector3int16.new" }
			}
		};

		public static Dictionary<string, string[]> BIT32 = new Dictionary<string, string[]>
		{
			{
				"bit32",
				new string[3] { "Class", "", "bit32" }
			},
			{
				"bit32.band",
				new string[3] { "Method", "", "bit32.band" }
			},
			{
				"bit32.extract",
				new string[3] { "Method", "", "bit32.extract" }
			},
			{
				"bit32.bor",
				new string[3] { "Method", "", "bit32.bor" }
			},
			{
				"bit32.bnot",
				new string[3] { "Method", "", "bit32.bnot" }
			},
			{
				"bit32.arshift",
				new string[3] { "Method", "", "bit32.arshift" }
			},
			{
				"bit32.rshift",
				new string[3] { "Method", "", "bit32.rshift" }
			},
			{
				"bit32.rrotate",
				new string[3] { "Method", "", "bit32.rrotate" }
			},
			{
				"bit32.replace",
				new string[3] { "Method", "", "bit32.replace" }
			},
			{
				"bit32.lshift",
				new string[3] { "Method", "", "bit32.lshift" }
			},
			{
				"bit32.lrotate",
				new string[3] { "Method", "", "bit32.lrotate" }
			},
			{
				"bit32.btest",
				new string[3] { "Method", "", "bit32.btest" }
			},
			{
				"bit32.bxor",
				new string[3] { "Method", "", "bit32.bxor" }
			}
		};

		public static Dictionary<string, string[]> REGION3INT16 = new Dictionary<string, string[]>
		{
			{
				"Region3int16",
				new string[3] { "Class", "", "Region3int16" }
			},
			{
				"Region3int16.new",
				new string[3] { "Method", "", "Region3int16.new" }
			}
		};

		public static Dictionary<string, string[]> NUMBERSEQUENCE = new Dictionary<string, string[]>
		{
			{
				"NumberSequence",
				new string[3] { "Class", "", "NumberSequence" }
			},
			{
				"NumberSequence.new",
				new string[3] { "Method", "", "NumberSequence.new" }
			}
		};

		public static Dictionary<string, string[]> UTF8 = new Dictionary<string, string[]>
		{
			{
				"utf8",
				new string[3] { "Class", "", "utf8" }
			},
			{
				"utf8.offset",
				new string[3] { "Method", "", "utf8.offset" }
			},
			{
				"utf8.codepoint",
				new string[3] { "Method", "", "utf8.codepoint" }
			},
			{
				"utf8.nfdnormalize",
				new string[3] { "Method", "", "utf8.nfdnormalize" }
			},
			{
				"utf8.char",
				new string[3] { "Method", "", "utf8.char" }
			},
			{
				"utf8.codes",
				new string[3] { "Method", "", "utf8.codes" }
			},
			{
				"utf8.len",
				new string[3] { "Method", "", "utf8.len" }
			},
			{
				"utf8.graphemes",
				new string[3] { "Method", "", "utf8.graphemes" }
			},
			{
				"utf8.nfcnormalize",
				new string[3] { "Method", "", "utf8.nfcnormalize" }
			}
		};

		public static Dictionary<string, string[]> PATHWAYPOINT = new Dictionary<string, string[]>
		{
			{
				"PathWaypoint",
				new string[3] { "Class", "", "PathWaypoint" }
			},
			{
				"PathWaypoint.new",
				new string[3] { "Method", "", "PathWaypoint.new" }
			}
		};

		public static Dictionary<string, string[]> COLORSEQUENCE = new Dictionary<string, string[]>
		{
			{
				"ColorSequence",
				new string[3] { "Class", "", "ColorSequence" }
			},
			{
				"ColorSequence.new",
				new string[3] { "Method", "", "ColorSequence.new" }
			}
		};

		public static Dictionary<string, string[]> UDIM2 = new Dictionary<string, string[]>
		{
			{
				"UDim2",
				new string[3] { "Class", "", "UDim2" }
			},
			{
				"UDim2.fromOffset",
				new string[3] { "Method", "", "UDim2.fromOffset" }
			},
			{
				"UDim2.fromScale",
				new string[3] { "Method", "", "UDim2.fromScale" }
			},
			{
				"UDim2.new",
				new string[3] { "Method", "", "UDim2.new" }
			}
		};

		public static Dictionary<string, string[]> INSTANCE = new Dictionary<string, string[]>
		{
			{
				"Instance",
				new string[3] { "Class", "", "Instance" }
			},
			{
				"Instance.new",
				new string[3] { "Method", "", "Instance.new" }
			}
		};

		public static Dictionary<string, string[]> RECT = new Dictionary<string, string[]>
		{
			{
				"Rect",
				new string[3] { "Class", "", "Rect" }
			},
			{
				"Rect.new",
				new string[3] { "Method", "", "Rect.new" }
			}
		};

		public static Dictionary<string, string[]> BRICKCOLOR = new Dictionary<string, string[]>
		{
			{
				"BrickColor",
				new string[3] { "Class", "", "BrickColor" }
			},
			{
				"BrickColor.Blue",
				new string[3] { "Method", "", "BrickColor.Blue" }
			},
			{
				"BrickColor.White",
				new string[3] { "Method", "", "BrickColor.White" }
			},
			{
				"BrickColor.Yellow",
				new string[3] { "Method", "", "BrickColor.Yellow" }
			},
			{
				"BrickColor.Red",
				new string[3] { "Method", "", "BrickColor.Red" }
			},
			{
				"BrickColor.Gray",
				new string[3] { "Method", "", "BrickColor.Gray" }
			},
			{
				"BrickColor.palette",
				new string[3] { "Method", "", "BrickColor.palette" }
			},
			{
				"BrickColor.New",
				new string[3] { "Method", "", "BrickColor.New" }
			},
			{
				"BrickColor.Black",
				new string[3] { "Method", "", "BrickColor.Black" }
			},
			{
				"BrickColor.Green",
				new string[3] { "Method", "", "BrickColor.Green" }
			},
			{
				"BrickColor.Random",
				new string[3] { "Method", "", "BrickColor.Random" }
			},
			{
				"BrickColor.DarkGray",
				new string[3] { "Method", "", "BrickColor.DarkGray" }
			},
			{
				"BrickColor.random",
				new string[3] { "Method", "", "BrickColor.random" }
			},
			{
				"BrickColor.new",
				new string[3] { "Method", "", "BrickColor.new" }
			}
		};

		public static Dictionary<string, string[]> STRING = new Dictionary<string, string[]>
		{
			{
				"string",
				new string[3] { "Class", "", "string" }
			},
			{
				"string.sub",
				new string[3] { "Method", "", "string.sub" }
			},
			{
				"string.split",
				new string[3] { "Method", "", "string.split" }
			},
			{
				"string.upper",
				new string[3] { "Method", "", "string.upper" }
			},
			{
				"string.len",
				new string[3] { "Method", "", "string.len" }
			},
			{
				"string.find",
				new string[3] { "Method", "", "string.find" }
			},
			{
				"string.match",
				new string[3] { "Method", "", "string.match" }
			},
			{
				"string.char",
				new string[3] { "Method", "", "string.char" }
			},
			{
				"string.rep",
				new string[3] { "Method", "", "string.rep" }
			},
			{
				"string.gmatch",
				new string[3] { "Method", "", "string.gmatch" }
			},
			{
				"string.reverse",
				new string[3] { "Method", "", "string.reverse" }
			},
			{
				"string.byte",
				new string[3] { "Method", "", "string.byte" }
			},
			{
				"string.format",
				new string[3] { "Method", "", "string.format" }
			},
			{
				"string.gsub",
				new string[3] { "Method", "", "string.gsub" }
			},
			{
				"string.lower",
				new string[3] { "Method", "", "string.lower" }
			}
		};

		public static Dictionary<string, string[]> standalone = new Dictionary<string, string[]>
		{
			{
				"tostring",
				new string[3] { "Function", "", "tostring" }
			},
			{
				"lockModule",
				new string[3] { "Function", "", "lockModule" }
			},
			{
				"getsenv",
				new string[3] { "Function", "", "getsenv" }
			},
			{
				"setrawmetatable",
				new string[3] { "Function", "", "setrawmetatable" }
			},
			{
				"queue_on_teleport",
				new string[3] { "Function", "", "queue_on_teleport" }
			},
			{
				"tonumber",
				new string[3] { "Function", "", "tonumber" }
			},
			{
				"Stats",
				new string[3] { "Function", "", "Stats" }
			},
			{
				"setthreadcontext",
				new string[3] { "Function", "", "setthreadcontext" }
			},
			{
				"getrenv",
				new string[3] { "Function", "", "getrenv" }
			},
			{
				"newcclosure",
				new string[3] { "Function", "", "newcclosure" }
			},
			{
				"request",
				new string[3] { "Function", "", "request" }
			},
			{
				"isluau",
				new string[3] { "Function", "", "isluau" }
			},
			{
				"decompile",
				new string[3] { "Function", "", "decompile" }
			},
			{
				"loadstring",
				new string[3] { "Function", "", "loadstring" }
			},
			{
				"printidentity",
				new string[3] { "Function", "", "printidentity" }
			},
			{
				"Version",
				new string[3] { "Function", "", "Version" }
			},
			{
				"getprotos",
				new string[3] { "Function", "", "getprotos" }
			},
			{
				"spawn",
				new string[3] { "Function", "", "spawn" }
			},
			{
				"hookfunction",
				new string[3] { "Function", "", "hookfunction" }
			},
			{
				"stats",
				new string[3] { "Function", "", "stats" }
			},
			{
				"getproto",
				new string[3] { "Function", "", "getproto" }
			},
			{
				"print",
				new string[3] { "Function", "", "print" }
			},
			{
				"getupvalue",
				new string[3] { "Function", "", "getupvalue" }
			},
			{
				"elapsedTime",
				new string[3] { "Function", "", "elapsedTime" }
			},
			{
				"ipairs",
				new string[3] { "Function", "", "ipairs" }
			},
			{
				"mouse1click",
				new string[3] { "Function", "", "mouse1click" }
			},
			{
				"collectgarbage",
				new string[3] { "Function", "", "collectgarbage" }
			},
			{
				"gethiddenproperty",
				new string[3] { "Function", "", "gethiddenproperty" }
			},
			{
				"getinstancecachekey",
				new string[3] { "Function", "", "getinstancecachekey" }
			},
			{
				"getnilinstances",
				new string[3] { "Function", "", "getnilinstances" }
			},
			{
				"time",
				new string[3] { "Function", "", "time" }
			},
			{
				"getupvalues",
				new string[3] { "Function", "", "getupvalues" }
			},
			{
				"type",
				new string[3] { "Function", "", "type" }
			},
			{
				"ElapsedTime",
				new string[3] { "Function", "", "ElapsedTime" }
			},
			{
				"setclipboard",
				new string[3] { "Function", "", "setclipboard" }
			},
			{
				"mouse2click",
				new string[3] { "Function", "", "mouse2click" }
			},
			{
				"getinfo",
				new string[3] { "Function", "", "getinfo" }
			},
			{
				"sethiddenproperty",
				new string[3] { "Function", "", "sethiddenproperty" }
			},
			{
				"loadfile",
				new string[3] { "Function", "", "loadfile" }
			},
			{
				"getconstant",
				new string[3] { "Function", "", "getconstant" }
			},
			{
				"warn",
				new string[3] { "Function", "", "warn" }
			},
			{
				"gcinfo",
				new string[3] { "Function", "", "gcinfo" }
			},
			{
				"tick",
				new string[3] { "Function", "", "tick" }
			},
			{
				"checkcaller",
				new string[3] { "Function", "", "checkcaller" }
			},
			{
				"getfenv",
				new string[3] { "Function", "", "getfenv" }
			},
			{
				"setreadonly",
				new string[3] { "Function", "", "setreadonly" }
			},
			{
				"mouse1up",
				new string[3] { "Function", "", "mouse1up" }
			},
			{
				"wait",
				new string[3] { "Function", "", "wait" }
			},
			{
				"Delay",
				new string[3] { "Function", "", "Delay" }
			},
			{
				"getconstants",
				new string[3] { "Function", "", "getconstants" }
			},
			{
				"traceback",
				new string[3] { "Function", "", "traceback" }
			},
			{
				"UserSettings",
				new string[3] { "Function", "", "UserSettings" }
			},
			{
				"readfile",
				new string[3] { "Function", "", "readfile" }
			},
			{
				"PluginManager",
				new string[3] { "Function", "", "PluginManager" }
			},
			{
				"getreg",
				new string[3] { "Function", "", "getreg" }
			},
			{
				"HttpPost",
				new string[3] { "Function", "", "HttpPost" }
			},
			{
				"delay",
				new string[3] { "Function", "", "delay" }
			},
			{
				"HttpGetAsync",
				new string[3] { "Function", "", "HttpGetAsync" }
			},
			{
				"HttpGet",
				new string[3] { "Function", "", "HttpGet" }
			},
			{
				"ypcall",
				new string[3] { "Function", "", "ypcall" }
			},
			{
				"getregistry",
				new string[3] { "Function", "", "getregistry" }
			},
			{
				"getgenv",
				new string[3] { "Function", "", "getgenv" }
			},
			{
				"setconstant",
				new string[3] { "Function", "", "setconstant" }
			},
			{
				"profilebegin",
				new string[3] { "Function", "", "profilebegin" }
			},
			{
				"setupvalue",
				new string[3] { "Function", "", "setupvalue" }
			},
			{
				"profileend",
				new string[3] { "Function", "", "profileend" }
			},
			{
				"typeof",
				new string[3] { "Function", "", "typeof" }
			},
			{
				"getcallingscript",
				new string[3] { "Function", "", "getcallingscript" }
			},
			{
				"is_luau",
				new string[3] { "Function", "", "is_luau" }
			},
			{
				"require",
				new string[3] { "Function", "", "require" }
			},
			{
				"writefile",
				new string[3] { "Function", "", "writefile" }
			},
			{
				"mouse2up",
				new string[3] { "Function", "", "mouse2up" }
			},
			{
				"setmetatable",
				new string[3] { "Function", "", "setmetatable" }
			},
			{
				"next",
				new string[3] { "Function", "", "next" }
			},
			{
				"mousemoverel",
				new string[3] { "Function", "", "mousemoverel" }
			},
			{
				"mouse2down",
				new string[3] { "Function", "", "mouse2down" }
			},
			{
				"mouse1down",
				new string[3] { "Function", "", "mouse1down" }
			},
			{
				"unlockModule",
				new string[3] { "Function", "", "unlockModule" }
			},
			{
				"islclosure",
				new string[3] { "Function", "", "islclosure" }
			},
			{
				"version",
				new string[3] { "Function", "", "version" }
			},
			{
				"xpcall",
				new string[3] { "Function", "", "xpcall" }
			},
			{
				"pairs",
				new string[3] { "Function", "", "pairs" }
			},
			{
				"newproxy",
				new string[3] { "Function", "", "newproxy" }
			},
			{
				"Spawn",
				new string[3] { "Function", "", "Spawn" }
			},
			{
				"assert",
				new string[3] { "Function", "", "assert" }
			},
			{
				"appendfile",
				new string[3] { "Function", "", "appendfile" }
			},
			{
				"getrawmetatable",
				new string[3] { "Function", "", "getrawmetatable" }
			},
			{
				"rawset",
				new string[3] { "Function", "", "rawset" }
			},
			{
				"getgc",
				new string[3] { "Function", "", "getgc" }
			},
			{
				"settings",
				new string[3] { "Function", "", "settings" }
			},
			{
				"iscclosure",
				new string[3] { "Function", "", "iscclosure" }
			},
			{
				"isreadonly",
				new string[3] { "Function", "", "isreadonly" }
			},
			{
				"getthreadcontext",
				new string[3] { "Function", "", "getthreadcontext" }
			},
			{
				"GetObjects",
				new string[3] { "Function", "", "GetObjects" }
			},
			{
				"run_secure",
				new string[3] { "Function", "", "run_secure" }
			},
			{
				"getnamecallmethod",
				new string[3] { "Function", "", "getnamecallmethod" }
			},
			{
				"rawequal",
				new string[3] { "Function", "", "rawequal" }
			},
			{
				"fireclickdetector",
				new string[3] { "Function", "", "fireclickdetector" }
			},
			{
				"unpack",
				new string[3] { "Function", "", "unpack" }
			},
			{
				"rawget",
				new string[3] { "Function", "", "rawget" }
			},
			{
				"Wait",
				new string[3] { "Function", "", "Wait" }
			},
			{
				"getmetatable",
				new string[3] { "Function", "", "getmetatable" }
			},
			{
				"setfenv",
				new string[3] { "Function", "", "setfenv" }
			},
			{
				"select",
				new string[3] { "Function", "", "select" }
			},
			{
				"pcall",
				new string[3] { "Function", "", "pcall" }
			},
			{
				"error",
				new string[3] { "Function", "", "error" }
			}
		};

		public static Dictionary<string, string[]> keywords = new Dictionary<string, string[]>
		{
			{
				"if",
				new string[3] { "Keyword", "", "if" }
			},
			{
				"else",
				new string[3] { "Keyword", "", "else" }
			},
			{
				"elseif",
				new string[3] { "Keyword", "", "elseif" }
			},
			{
				"while",
				new string[3] { "Keyword", "", "while" }
			},
			{
				"do",
				new string[3] { "Keyword", "", "do" }
			},
			{
				"function",
				new string[3] { "Keyword", "", "function" }
			},
			{
				"repeat",
				new string[3] { "Keyword", "", "repeat" }
			},
			{
				"until",
				new string[3] { "Keyword", "", "until" }
			},
			{
				"for",
				new string[3] { "Keyword", "", "for" }
			},
			{
				"in",
				new string[3] { "Keyword", "", "in" }
			},
			{
				"next",
				new string[3] { "Keyword", "", "next" }
			},
			{
				"continue",
				new string[3] { "Keyword", "", "continue" }
			},
			{
				"break",
				new string[3] { "Keyword", "", "break" }
			},
			{
				"return",
				new string[3] { "Keyword", "", "return" }
			},
			{
				"true",
				new string[3] { "Keyword", "", "true" }
			},
			{
				"false",
				new string[3] { "Keyword", "", "false" }
			},
			{
				"and",
				new string[3] { "Keyword", "", "and" }
			},
			{
				"or",
				new string[3] { "Keyword", "", "or" }
			},
			{
				"end",
				new string[3] { "Keyword", "", "end" }
			},
			{
				"local",
				new string[3] { "Keyword", "", "local" }
			},
			{
				"then",
				new string[3] { "Keyword", "", "then" }
			}
		};

		public static void addIntellisense(ChromiumWebBrowser chrome)
		{
			Intellisense intellisense = new Intellisense();
			Type type = intellisense.GetType();
			FieldInfo[] fields = type.GetFields();
			for (int i = 0; i < fields.Length; i++)
			{
				Dictionary<string, string[]> dictionary = fields[i].GetValue(intellisense) as Dictionary<string, string[]>;
				for (int j = 0; j < dictionary.Keys.Count; j++)
				{
					dictionary.TryGetValue(dictionary.Keys.ToList()[j], out var value);
					if (value != null)
					{
						try
						{
							WebBrowserExtensions.ExecuteScriptAsyncWhenPageLoaded((IWebBrowser)(object)chrome, "AddIntellisense('" + dictionary.Keys.ToList()[j] + "', '" + value[0] + "', '" + value[1] + "', '" + value[2] + "')", true);
						}
						catch
						{
						}
					}
				}
			}
		}
	}
}
