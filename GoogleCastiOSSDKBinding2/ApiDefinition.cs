using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace GoogleCastiOSSDKBinding
{
	[Static]
	partial interface Constants
	{
		// extern NSString *const kGCKExpandedMediaControlsTriggeredNotification;
		[Field("kGCKExpandedMediaControlsTriggeredNotification", "__Internal")]
		NSString kGCKExpandedMediaControlsTriggeredNotification { get; }

		// extern NSString *const kGCKNotificationKeyCastState;
		[Field("kGCKNotificationKeyCastState", "__Internal")]
		NSString kGCKNotificationKeyCastState { get; }
	}

	// @interface GCKCastContext : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKCastContext
	{
		// @property (readonly, assign, nonatomic) int castState;
		[Export("castState")]
		int CastState { get; }

		// @property (readonly, nonatomic, strong) GCKDiscoveryManager * discoveryManager;
		[Export("discoveryManager", ArgumentSemantic.Strong)]
		GCKDiscoveryManager DiscoveryManager { get; }

		// @property (readonly, nonatomic, strong) GCKSessionManager * sessionManager;
		[Export("sessionManager", ArgumentSemantic.Strong)]
		GCKSessionManager SessionManager { get; }

		// +(void)setSharedInstanceWithOptions:(id)options;
		[Static]
		[Export("setSharedInstanceWithOptions:")]
		void SetSharedInstanceWithOptions(NSObject options);

		// +(instancetype)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		GCKCastContext SharedInstance();

		// -(void)registerDeviceProvider:(GCKDeviceProvider *)deviceProvider;
		[Export("registerDeviceProvider:")]
		void RegisterDeviceProvider(GCKDeviceProvider deviceProvider);

		// -(void)unregisterDeviceProviderForCategory:(NSString *)category;
		[Export("unregisterDeviceProviderForCategory:")]
		void UnregisterDeviceProviderForCategory(string category);
	}

	// @protocol GCKCastDeviceStatusListener <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKCastDeviceStatusListener
	{
		// @optional -(void)castSession:(id)castSession didReceiveActiveInputStatus:(id)activeInputStatus;
		[Export("castSession:didReceiveActiveInputStatus:")]
		void DidReceiveActiveInputStatus(NSObject castSession, NSObject activeInputStatus);

		// @optional -(void)castSession:(id)castSession didReceiveStandbyStatus:(id)standbyStatus;
		[Export("castSession:didReceiveStandbyStatus:")]
		void DidReceiveStandbyStatus(NSObject castSession, NSObject standbyStatus);

		// @optional -(void)castSession:(id)castSession didReceiveMultizoneStatus:(GCKMultizoneStatus *)multizoneStatus;
		[Export("castSession:didReceiveMultizoneStatus:")]
		void DidReceiveMultizoneStatus(NSObject castSession, GCKMultizoneStatus multizoneStatus);

		// @optional -(void)castSession:(id)castSession didAddMultizoneDevice:(GCKMultizoneDevice *)device;
		[Export("castSession:didAddMultizoneDevice:")]
		void DidAddMultizoneDevice(NSObject castSession, GCKMultizoneDevice device);

		// @optional -(void)castSession:(id)castSession didUpdateMultizoneDevice:(GCKMultizoneDevice *)device;
		[Export("castSession:didUpdateMultizoneDevice:")]
		void DidUpdateMultizoneDevice(NSObject castSession, GCKMultizoneDevice device);

		// @optional -(void)castSession:(id)castSession didRemoveMultizoneDeviceWithID:(NSString *)deviceID;
		[Export("castSession:didRemoveMultizoneDeviceWithID:")]
		void DidRemoveMultizoneDeviceWithID(NSObject castSession, string deviceID);
	}

	partial interface Constants
	{
		// extern NSString *const kGCKFrameworkVersion;
		[Field("kGCKFrameworkVersion", "__Internal")]
		NSString kGCKFrameworkVersion { get; }
	}

	partial interface Constants
	{
		// extern const NSInteger kGCKDeviceCapabilityVideoOut __attribute__((visibility("default"))) __attribute__((deprecated("Use GCKDeviceCapabilityVideoOut")));
		[Field("kGCKDeviceCapabilityVideoOut", "__Internal")]
		nint kGCKDeviceCapabilityVideoOut { get; }

		// extern const NSInteger kGCKDeviceCapabilityVideoIn __attribute__((visibility("default"))) __attribute__((deprecated("Use GCKDeviceCapabilityVideoIn")));
		[Field("kGCKDeviceCapabilityVideoIn", "__Internal")]
		nint kGCKDeviceCapabilityVideoIn { get; }

		// extern const NSInteger kGCKDeviceCapabilityAudioOut __attribute__((visibility("default"))) __attribute__((deprecated("Use GCKDeviceCapabilityAudioOut")));
		[Field("kGCKDeviceCapabilityAudioOut", "__Internal")]
		nint kGCKDeviceCapabilityAudioOut { get; }

		// extern const NSInteger kGCKDeviceCapabilityAudioIn __attribute__((visibility("default"))) __attribute__((deprecated("Use GCKDeviceCapabilityAudioIn")));
		[Field("kGCKDeviceCapabilityAudioIn", "__Internal")]
		nint kGCKDeviceCapabilityAudioIn { get; }

		// extern NSString *const _Nonnull kGCKCastDeviceCategory __attribute__((visibility("default")));
		[Field("kGCKCastDeviceCategory", "__Internal")]
		NSString kGCKCastDeviceCategory { get; }
	}

	// @interface GCKDevice : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface GCKDevice : INSCopying, INSCoding
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull ipAddress;
		[Export("ipAddress")]
		string IpAddress { get; }

		// @property (readonly, assign, nonatomic) uint16_t servicePort;
		[Export("servicePort")]
		ushort ServicePort { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull deviceID;
		[Export("deviceID")]
		string DeviceID { get; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable friendlyName;
		[NullAllowed, Export("friendlyName")]
		string FriendlyName { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable manufacturer;
		[NullAllowed, Export("manufacturer")]
		string Manufacturer { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable modelName;
		[NullAllowed, Export("modelName")]
		string ModelName { get; set; }

		// @property (readwrite, copy, nonatomic) NSArray<GCKImage *> * _Nullable icons;
		[NullAllowed, Export("icons", ArgumentSemantic.Copy)]
		GCKImage[] Icons { get; set; }

		// @property (assign, readwrite, nonatomic) GCKDeviceStatus status;
		[Export("status", ArgumentSemantic.Assign)]
		GCKDeviceStatus Status { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable statusText;
		[NullAllowed, Export("statusText")]
		string StatusText { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable deviceVersion;
		[NullAllowed, Export("deviceVersion")]
		string DeviceVersion { get; set; }

		// @property (readonly, assign, nonatomic) BOOL isOnLocalNetwork;
		[Export("isOnLocalNetwork")]
		bool IsOnLocalNetwork { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull category;
		[Export("category")]
		string Category { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull uniqueID;
		[Export("uniqueID")]
		string UniqueID { get; }

		// -(BOOL)isSameDeviceAs:(const GCKDevice * _Nonnull)other;
		[Export("isSameDeviceAs:")]
		bool IsSameDeviceAs(GCKDevice other);

		// -(BOOL)hasCapabilities:(NSInteger)deviceCapabilities;
		[Export("hasCapabilities:")]
		bool HasCapabilities(nint deviceCapabilities);

		// -(void)setAttribute:(NSObject<NSCoding> * _Nonnull)attribute forKey:(NSString * _Nonnull)key;
		[Export("setAttribute:forKey:")]
		void SetAttribute(NSCoding attribute, string key);

		// -(NSObject<NSCoding> * _Nullable)attributeForKey:(NSString * _Nonnull)key;
		[Export("attributeForKey:")]
		[return: NullAllowed]
		NSCoding AttributeForKey(string key);

		// -(void)removeAttributeForKey:(NSString * _Nonnull)key;
		[Export("removeAttributeForKey:")]
		void RemoveAttributeForKey(string key);

		// -(void)removeAllAttributes;
		[Export("removeAllAttributes")]
		void RemoveAllAttributes();
	}

	// @interface GCKDeviceManager : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKDeviceManager
	{
		// @property (readonly, assign, nonatomic) BOOL ignoreAppStateNotifications;
		[Export("ignoreAppStateNotifications")]
		bool IgnoreAppStateNotifications { get; }

		// @property (readonly, assign, nonatomic) GCKConnectionState connectionState;
		[Export("connectionState", ArgumentSemantic.Assign)]
		GCKConnectionState ConnectionState { get; }

		// @property (readonly, assign, nonatomic) GCKConnectionState applicationConnectionState;
		[Export("applicationConnectionState", ArgumentSemantic.Assign)]
		GCKConnectionState ApplicationConnectionState { get; }

		// @property (readonly, assign, nonatomic) BOOL isConnected __attribute__((deprecated("Use connectionState")));
		[Export("isConnected")]
		bool IsConnected { get; }

		// @property (readonly, assign, nonatomic) BOOL isConnectedToApp __attribute__((deprecated("Use applicationConnectionState")));
		[Export("isConnectedToApp")]
		bool IsConnectedToApp { get; }

		// @property (readonly, assign, nonatomic) BOOL isReconnecting;
		[Export("isReconnecting")]
		bool IsReconnecting { get; }

		// @property (assign, readwrite, nonatomic) NSTimeInterval reconnectTimeout;
		[Export("reconnectTimeout")]
		double ReconnectTimeout { get; set; }

		// @property (readonly, assign, nonatomic) GCKDevice * _Nonnull device;
		[Export("device", ArgumentSemantic.Assign)]
		GCKDevice Device { get; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		GCKDeviceManagerDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<GCKDeviceManagerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, assign, nonatomic) float deviceVolume;
		[Export("deviceVolume")]
		float DeviceVolume { get; }

		// @property (readonly, assign, nonatomic) BOOL deviceMuted;
		[Export("deviceMuted")]
		bool DeviceMuted { get; }

		// @property (readonly, assign, nonatomic) GCKActiveInputStatus activeInputStatus;
		[Export("activeInputStatus", ArgumentSemantic.Assign)]
		GCKActiveInputStatus ActiveInputStatus { get; }

		// @property (readonly, assign, nonatomic) GCKStandbyStatus standbyStatus;
		[Export("standbyStatus", ArgumentSemantic.Assign)]
		GCKStandbyStatus StandbyStatus { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable applicationSessionID;
		[NullAllowed, Export("applicationSessionID")]
		string ApplicationSessionID { get; }

		// @property (readonly, copy, nonatomic) GCKApplicationMetadata * _Nullable applicationMetadata;
		[NullAllowed, Export("applicationMetadata", ArgumentSemantic.Copy)]
		GCKApplicationMetadata ApplicationMetadata { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable applicationStatusText;
		[NullAllowed, Export("applicationStatusText")]
		string ApplicationStatusText { get; }

		// -(instancetype _Nonnull)initWithDevice:(GCKDevice * _Nonnull)device clientPackageName:(NSString * _Nonnull)clientPackageName;
		[Export("initWithDevice:clientPackageName:")]
		IntPtr Constructor(GCKDevice device, string clientPackageName);

		// -(instancetype _Nonnull)initWithDevice:(GCKDevice * _Nonnull)device clientPackageName:(NSString * _Nonnull)clientPackageName ignoreAppStateNotifications:(BOOL)ignoreAppStateNotifications;
		[Export("initWithDevice:clientPackageName:ignoreAppStateNotifications:")]
		IntPtr Constructor(GCKDevice device, string clientPackageName, bool ignoreAppStateNotifications);

		// -(void)connect;
		[Export("connect")]
		void Connect();

		// -(void)disconnect;
		[Export("disconnect")]
		void Disconnect();

		// -(void)disconnectWithLeave:(BOOL)leaveApplication;
		[Export("disconnectWithLeave:")]
		void DisconnectWithLeave(bool leaveApplication);

		// -(BOOL)addChannel:(GCKCastChannel * _Nonnull)channel;
		[Export("addChannel:")]
		bool AddChannel(GCKCastChannel channel);

		// -(BOOL)removeChannel:(GCKCastChannel * _Nonnull)channel;
		[Export("removeChannel:")]
		bool RemoveChannel(GCKCastChannel channel);

		// -(NSInteger)launchApplication:(NSString * _Nonnull)applicationID;
		[Export("launchApplication:")]
		nint LaunchApplication(string applicationID);

		// -(NSInteger)launchApplication:(NSString * _Nonnull)applicationID withLaunchOptions:(GCKLaunchOptions * _Nullable)launchOptions;
		[Export("launchApplication:withLaunchOptions:")]
		nint LaunchApplication(string applicationID, [NullAllowed] GCKLaunchOptions launchOptions);

		// -(NSInteger)launchApplication:(NSString * _Nonnull)applicationID relaunchIfRunning:(BOOL)relaunchIfRunning __attribute__((deprecated("Use launchApplication:withLaunchOptions:")));
		[Export("launchApplication:relaunchIfRunning:")]
		nint LaunchApplication(string applicationID, bool relaunchIfRunning);

		// -(NSInteger)joinApplication:(NSString * _Nullable)applicationID;
		[Export("joinApplication:")]
		nint JoinApplication([NullAllowed] string applicationID);

		// -(NSInteger)joinApplication:(NSString * _Nonnull)applicationID sessionID:(NSString * _Nonnull)sessionID;
		[Export("joinApplication:sessionID:")]
		nint JoinApplication(string applicationID, string sessionID);

		// -(BOOL)leaveApplication;
		[Export("leaveApplication")]
		bool LeaveApplication();

		// -(NSInteger)stopApplication;
		[Export("stopApplication")]
		nint StopApplication();

		// -(NSInteger)stopApplicationWithSessionID:(NSString * _Nullable)sessionID;
		[Export("stopApplicationWithSessionID:")]
		nint StopApplicationWithSessionID([NullAllowed] string sessionID);

		// -(NSInteger)setVolume:(float)volume;
		[Export("setVolume:")]
		nint SetVolume(float volume);

		// -(NSInteger)setMuted:(BOOL)muted;
		[Export("setMuted:")]
		nint SetMuted(bool muted);

		// -(NSInteger)requestDeviceStatus;
		[Export("requestDeviceStatus")]
		nint RequestDeviceStatus();
	}

	// @protocol GCKDeviceManagerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKDeviceManagerDelegate
	{
		// @optional -(void)deviceManagerDidConnect:(GCKDeviceManager * _Nonnull)deviceManager;
		[Export("deviceManagerDidConnect:")]
		void DeviceManagerDidConnect(GCKDeviceManager deviceManager);

		// @optional -(void)deviceManager:(GCKDeviceManager * _Nonnull)deviceManager didFailToConnectWithError:(NSError * _Nonnull)error;
		[Export("deviceManager:didFailToConnectWithError:")]
		void DeviceManagerDidFailToConnectWithError(GCKDeviceManager deviceManager, NSError error);

		// @optional -(void)deviceManager:(GCKDeviceManager * _Nonnull)deviceManager didDisconnectWithError:(NSError * _Nullable)error;
		[Export("deviceManager:didDisconnectWithError:")]
		void DeviceManagerDidDisconnectWithError(GCKDeviceManager deviceManager, [NullAllowed] NSError error);

		// @optional -(void)deviceManager:(GCKDeviceManager * _Nonnull)deviceManager didSuspendConnectionWithReason:(GCKConnectionSuspendReason)reason;
		[Export("deviceManager:didSuspendConnectionWithReason:")]
		void DeviceManagerDidSuspendConnectionWithReason(GCKDeviceManager deviceManager, GCKConnectionSuspendReason reason);

		// @optional -(void)deviceManagerDidResumeConnection:(GCKDeviceManager * _Nonnull)deviceManager rejoinedApplication:(BOOL)rejoinedApplication;
		[Export("deviceManagerDidResumeConnection:rejoinedApplication:")]
		void DeviceManagerDidResumeConnection(GCKDeviceManager deviceManager, bool rejoinedApplication);

		// @optional -(void)deviceManager:(GCKDeviceManager * _Nonnull)deviceManager didConnectToCastApplication:(GCKApplicationMetadata * _Nonnull)applicationMetadata sessionID:(NSString * _Nonnull)sessionID launchedApplication:(BOOL)launchedApplication;
		[Export("deviceManager:didConnectToCastApplication:sessionID:launchedApplication:")]
		void DeviceManagerDidConnectToCastApplication(GCKDeviceManager deviceManager, GCKApplicationMetadata applicationMetadata, string sessionID, bool launchedApplication);

		// @optional -(void)deviceManager:(GCKDeviceManager * _Nonnull)deviceManager didFailToConnectToApplicationWithError:(NSError * _Nonnull)error;
		[Export("deviceManager:didFailToConnectToApplicationWithError:")]
		void DeviceManagerDidFailToConnectToApplicationWithError(GCKDeviceManager deviceManager, NSError error);

		// @optional -(void)deviceManager:(GCKDeviceManager * _Nonnull)deviceManager didDisconnectFromApplicationWithError:(NSError * _Nullable)error;
		[Export("deviceManager:didDisconnectFromApplicationWithError:")]
		void DeviceManagerDidDisconnectFromApplicationWithError(GCKDeviceManager deviceManager, [NullAllowed] NSError error);

		// @optional -(void)deviceManagerDidStopApplication:(GCKDeviceManager * _Nonnull)deviceManager;
		[Export("deviceManagerDidStopApplication:")]
		void DeviceManagerDidStopApplication(GCKDeviceManager deviceManager);

		// @optional -(void)deviceManager:(GCKDeviceManager * _Nonnull)deviceManager didFailToStopApplicationWithError:(NSError * _Nonnull)error;
		[Export("deviceManager:didFailToStopApplicationWithError:")]
		void DeviceManagerDidFailToStopApplicationWithError(GCKDeviceManager deviceManager, NSError error);

		// @optional -(void)deviceManager:(GCKDeviceManager * _Nonnull)deviceManager didReceiveApplicationMetadata:(GCKApplicationMetadata * _Nullable)metadata;
		[Export("deviceManager:didReceiveApplicationMetadata:")]
		void DeviceManagerDidReceiveApplicationMetadata(GCKDeviceManager deviceManager, [NullAllowed] GCKApplicationMetadata metadata);

		// @optional -(void)deviceManager:(GCKDeviceManager * _Nonnull)deviceManager didReceiveApplicationStatusText:(NSString * _Nullable)applicationStatusText;
		[Export("deviceManager:didReceiveApplicationStatusText:")]
		void DeviceManagerDidReceiveApplicationStatusText(GCKDeviceManager deviceManager, [NullAllowed] string applicationStatusText);

		// @optional -(void)deviceManager:(GCKDeviceManager * _Nonnull)deviceManager volumeDidChangeToLevel:(float)volumeLevel isMuted:(BOOL)isMuted;
		[Export("deviceManager:volumeDidChangeToLevel:isMuted:")]
		void DeviceManagerVolumeDidChangeToLevel(GCKDeviceManager deviceManager, float volumeLevel, bool isMuted);

		// @optional -(void)deviceManager:(GCKDeviceManager * _Nonnull)deviceManager didReceiveActiveInputStatus:(GCKActiveInputStatus)activeInputStatus;
		[Export("deviceManager:didReceiveActiveInputStatus:")]
		void DeviceManagerDidReceiveActiveInputStatus(GCKDeviceManager deviceManager, GCKActiveInputStatus activeInputStatus);

		// @optional -(void)deviceManager:(GCKDeviceManager * _Nonnull)deviceManager didReceiveStandbyStatus:(GCKStandbyStatus)standbyStatus;
		[Export("deviceManager:didReceiveStandbyStatus:")]
		void DeviceManagerDidReceiveStandbyStatus(GCKDeviceManager deviceManager, GCKStandbyStatus standbyStatus);

		// @optional -(void)deviceManager:(GCKDeviceManager * _Nonnull)deviceManager request:(NSInteger)requestID didFailWithError:(NSError * _Nonnull)error;
		[Export("deviceManager:request:didFailWithError:")]
		void DeviceManagerRequestDidFailWithError(GCKDeviceManager deviceManager, nint requestID, NSError error);

		// @optional -(void)deviceManagerDidPair:(GCKDeviceManager * _Nonnull)deviceManager withGuestModeDevice:(GCKDevice * _Nonnull)guestModeDevice;
		[Export("deviceManagerDidPair:withGuestModeDevice:")]
		void DeviceManagerDidPair(GCKDeviceManager deviceManager, GCKDevice guestModeDevice);
	}

	// @interface Protected (GCKDeviceProvider)
	[Category]
	[BaseType(typeof(GCKDeviceProvider))]
	interface GCKDeviceProvider_Protected
	{
		// -(void)notifyDidStartDiscovery;
		[Export("notifyDidStartDiscovery")]
		void NotifyDidStartDiscovery();

		// -(void)notifyDidPublishDevice:(GCKDevice * _Nonnull)device;
		[Export("notifyDidPublishDevice:")]
		void NotifyDidPublishDevice(GCKDevice device);

		// -(void)notifyDidUnpublishDevice:(GCKDevice * _Nonnull)device;
		[Export("notifyDidUnpublishDevice:")]
		void NotifyDidUnpublishDevice(GCKDevice device);

		// -(void)notifyDidUpdateDevice:(GCKDevice * _Nonnull)device;
		[Export("notifyDidUpdateDevice:")]
		void NotifyDidUpdateDevice(GCKDevice device);

		// -(GCKDevice * _Nonnull)createDeviceWithID:(NSString * _Nonnull)deviceID ipAddress:(NSString * _Nonnull)ipAddress servicePort:(uint16_t)servicePort;
		[Export("createDeviceWithID:ipAddress:servicePort:")]
		GCKDevice CreateDeviceWithID(string deviceID, string ipAddress, ushort servicePort);
	}

	// @interface GCKDeviceProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKDeviceProvider
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull deviceCategory;
		[Export("deviceCategory")]
		string DeviceCategory { get; }

		// @property (assign, readwrite, nonatomic) BOOL passiveScan;
		[Export("passiveScan")]
		bool PassiveScan { get; set; }

		// @property (readonly, copy, nonatomic) NSArray<GCKDevice *> * _Nonnull devices;
		[Export("devices", ArgumentSemantic.Copy)]
		GCKDevice[] Devices { get; }

		// -(instancetype _Nonnull)initWithDeviceCategory:(NSString * _Nonnull)deviceCategory;
		[Export("initWithDeviceCategory:")]
		IntPtr Constructor(string deviceCategory);

		// -(void)startDiscovery;
		[Export("startDiscovery")]
		void StartDiscovery();

		// -(void)stopDiscovery;
		[Export("stopDiscovery")]
		void StopDiscovery();

		// -(id)createSessionForDevice:(GCKDevice * _Nonnull)device sessionID:(NSString * _Nullable)sessionID;
		[Export("createSessionForDevice:sessionID:")]
		NSObject CreateSessionForDevice(GCKDevice device, [NullAllowed] string sessionID);
	}

	// @interface GCKDeviceScanner : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKDeviceScanner
	{
		// @property (readonly, copy, nonatomic) NSArray * _Nonnull devices;
		[Export("devices", ArgumentSemantic.Copy)]
		NSObject[] Devices { get; }

		// @property (readonly, nonatomic) BOOL hasDiscoveredDevices;
		[Export("hasDiscoveredDevices")]
		bool HasDiscoveredDevices { get; }

		// @property (readonly, nonatomic) BOOL scanning;
		[Export("scanning")]
		bool Scanning { get; }

		// @property (readwrite, copy, nonatomic) GCKFilterCriteria * _Nonnull filterCriteria;
		[Export("filterCriteria", ArgumentSemantic.Copy)]
		GCKFilterCriteria FilterCriteria { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL passiveScan;
		[Export("passiveScan")]
		bool PassiveScan { get; set; }

		// -(instancetype _Nonnull)initWithFilterCriteria:(GCKFilterCriteria * _Nullable)filterCriteria;
		[Export("initWithFilterCriteria:")]
		IntPtr Constructor([NullAllowed] GCKFilterCriteria filterCriteria);

		// -(void)startScan;
		[Export("startScan")]
		void StartScan();

		// -(void)stopScan;
		[Export("stopScan")]
		void StopScan();

		// -(void)addListener:(id<GCKDeviceScannerListener> _Nonnull)listener;
		[Export("addListener:")]
		void AddListener(GCKDeviceScannerListener listener);

		// -(void)removeListener:(id<GCKDeviceScannerListener> _Nonnull)listener;
		[Export("removeListener:")]
		void RemoveListener(GCKDeviceScannerListener listener);
	}

	// @protocol GCKDeviceScannerListener <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKDeviceScannerListener
	{
		// @optional -(void)deviceDidComeOnline:(GCKDevice * _Nonnull)device;
		[Export("deviceDidComeOnline:")]
		void DeviceDidComeOnline(GCKDevice device);

		// @optional -(void)deviceDidGoOffline:(GCKDevice * _Nonnull)device;
		[Export("deviceDidGoOffline:")]
		void DeviceDidGoOffline(GCKDevice device);

		// @optional -(void)deviceDidChange:(GCKDevice * _Nonnull)device;
		[Export("deviceDidChange:")]
		void DeviceDidChange(GCKDevice device);
	}

	partial interface Constants
	{
		// extern NSString *const _Nonnull kGCKKeyHasDiscoveredDevices __attribute__((visibility("default")));
		[Field("kGCKKeyHasDiscoveredDevices", "__Internal")]
		NSString kGCKKeyHasDiscoveredDevices { get; }
	}

	// @interface GCKDiscoveryManager : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKDiscoveryManager
	{
		// @property (readonly, assign, nonatomic) GCKDiscoveryState discoveryState;
		[Export("discoveryState", ArgumentSemantic.Assign)]
		GCKDiscoveryState DiscoveryState { get; }

		// @property (readonly, assign, nonatomic) BOOL hasDiscoveredDevices;
		[Export("hasDiscoveredDevices")]
		bool HasDiscoveredDevices { get; }

		// @property (assign, readwrite, nonatomic) BOOL passiveScan;
		[Export("passiveScan")]
		bool PassiveScan { get; set; }

		// @property (readonly, assign, nonatomic) NSUInteger deviceCount;
		[Export("deviceCount")]
		nuint DeviceCount { get; }

		// -(void)addListener:(id<GCKDiscoveryManagerListener> _Nonnull)listener;
		[Export("addListener:")]
		void AddListener(GCKDiscoveryManagerListener listener);

		// -(void)removeListener:(id<GCKDiscoveryManagerListener> _Nonnull)listener;
		[Export("removeListener:")]
		void RemoveListener(GCKDiscoveryManagerListener listener);

		// -(void)startDiscovery;
		[Export("startDiscovery")]
		void StartDiscovery();

		// -(void)stopDiscovery;
		[Export("stopDiscovery")]
		void StopDiscovery();

		// -(BOOL)isDiscoveryActiveForDeviceCategory:(NSString * _Nonnull)deviceCategory;
		[Export("isDiscoveryActiveForDeviceCategory:")]
		bool IsDiscoveryActiveForDeviceCategory(string deviceCategory);

		// -(GCKDevice * _Nonnull)deviceAtIndex:(NSUInteger)index;
		[Export("deviceAtIndex:")]
		GCKDevice DeviceAtIndex(nuint index);

		// -(GCKDevice * _Nullable)deviceWithUniqueID:(NSString * _Nonnull)uniqueID;
		[Export("deviceWithUniqueID:")]
		[return: NullAllowed]
		GCKDevice DeviceWithUniqueID(string uniqueID);
	}

	// @protocol GCKDiscoveryManagerListener <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKDiscoveryManagerListener
	{
		// @optional -(void)didStartDiscoveryForDeviceCategory:(NSString * _Nonnull)deviceCategory;
		[Export("didStartDiscoveryForDeviceCategory:")]
		void DidStartDiscoveryForDeviceCategory(string deviceCategory);

		// @optional -(void)willUpdateDeviceList;
		[Export("willUpdateDeviceList")]
		void WillUpdateDeviceList();

		// @optional -(void)didUpdateDeviceList;
		[Export("didUpdateDeviceList")]
		void DidUpdateDeviceList();

		// @optional -(void)didInsertDevice:(GCKDevice * _Nonnull)device atIndex:(NSUInteger)index;
		[Export("didInsertDevice:atIndex:")]
		void DidInsertDevice(GCKDevice device, nuint index);

		// @optional -(void)didUpdateDevice:(GCKDevice * _Nonnull)device atIndex:(NSUInteger)index;
		[Export("didUpdateDevice:atIndex:")]
		void DidUpdateDevice(GCKDevice device, nuint index);

		// @optional -(void)didUpdateDevice:(GCKDevice * _Nonnull)device atIndex:(NSUInteger)index andMoveToIndex:(NSUInteger)newIndex;
		[Export("didUpdateDevice:atIndex:andMoveToIndex:")]
		void DidUpdateDevice(GCKDevice device, nuint index, nuint newIndex);

		// @optional -(void)didRemoveDeviceAtIndex:(NSUInteger)index;
		[Export("didRemoveDeviceAtIndex:")]
		void DidRemoveDeviceAtIndex(nuint index);
	}

	partial interface Constants
	{
		// extern NSString *const _Nonnull kGCKErrorCustomDataKey __attribute__((visibility("default")));
		[Field("kGCKErrorCustomDataKey", "__Internal")]
		NSString kGCKErrorCustomDataKey { get; }

		// extern NSString *const _Nonnull kGCKErrorDomain __attribute__((visibility("default")));
		[Field("kGCKErrorDomain", "__Internal")]
		NSString kGCKErrorDomain { get; }
	}

	// @interface GCKError : NSError
	[BaseType(typeof(NSError))]
	interface GCKError
	{
		// +(GCKError * _Nonnull)errorWithCode:(GCKErrorCode)code;
		[Static]
		[Export("errorWithCode:")]
		GCKError ErrorWithCode(GCKErrorCode code);

		// +(GCKError * _Nonnull)errorWithCode:(GCKErrorCode)code customData:(id _Nullable)customData;
		[Static]
		[Export("errorWithCode:customData:")]
		GCKError ErrorWithCode(GCKErrorCode code, [NullAllowed] NSObject customData);

		// +(NSString * _Nonnull)enumDescriptionForCode:(GCKErrorCode)code;
		[Static]
		[Export("enumDescriptionForCode:")]
		string EnumDescriptionForCode(GCKErrorCode code);
	}

	// @interface GCKFilterCriteria : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface GCKFilterCriteria : INSCopying, INSCoding
	{
		// +(instancetype _Nonnull)criteriaForAvailableApplicationWithID:(NSString * _Nullable)applicationID;
		[Static]
		[Export("criteriaForAvailableApplicationWithID:")]
		GCKFilterCriteria CriteriaForAvailableApplicationWithID([NullAllowed] string applicationID);

		// +(instancetype _Nonnull)criteriaForRunningApplicationWithID:(NSString * _Nullable)applicationID supportedNamespaces:(NSArray<NSString *> * _Nullable)supportedNamespaces __attribute__((deprecated("Use criteriaForRunningApplicationWithSupportedNamespaces")));
		[Static]
		[Export("criteriaForRunningApplicationWithID:supportedNamespaces:")]
		GCKFilterCriteria CriteriaForRunningApplicationWithID([NullAllowed] string applicationID, [NullAllowed] string[] supportedNamespaces);

		// +(instancetype _Nonnull)criteriaForRunningApplicationWithSupportedNamespaces:(NSArray<NSString *> * _Nonnull)supportedNamespaces;
		[Static]
		[Export("criteriaForRunningApplicationWithSupportedNamespaces:")]
		GCKFilterCriteria CriteriaForRunningApplicationWithSupportedNamespaces(string[] supportedNamespaces);
	}

	// @interface GCKFrameworkResources : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKFrameworkResources
	{
		// +(instancetype _Nonnull)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		GCKFrameworkResources SharedInstance();

		// @property (readonly, nonatomic) NSBundle * _Nonnull bundle;
		[Export("bundle")]
		NSBundle Bundle { get; }

		// -(UIImage * _Nonnull)imageNamed:(NSString * _Nonnull)name;
		[Export("imageNamed:")]
		UIImage ImageNamed(string name);

		// -(UIImage * _Nonnull)imageNamed:(NSString * _Nonnull)name withRenderingMode:(UIImageRenderingMode)renderingMode;
		[Export("imageNamed:withRenderingMode:")]
		UIImage ImageNamed(string name, UIImageRenderingMode renderingMode);

		// -(NSArray * _Nonnull)nibNamed:(NSString * _Nonnull)name owner:(id _Nonnull)owner replacementObjects:(NSDictionary * _Nullable)objects;
		[Export("nibNamed:owner:replacementObjects:")]
		NSObject[] NibNamed(string name, NSObject owner, [NullAllowed] NSDictionary objects);

		// -(UIStoryboard * _Nonnull)storyboardNamed:(NSString * _Nonnull)name;
		[Export("storyboardNamed:")]
		UIStoryboard StoryboardNamed(string name);
	}

	// @interface GCKGameManagerChannel
	[BaseType(typeof(GCKCastChannel))]
	interface GCKGameManagerChannel
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		GCKGameManagerChannelDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<GCKGameManagerChannelDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) GCKGameManagerState * _Nullable currentState;
		[NullAllowed, Export("currentState", ArgumentSemantic.Strong)]
		GCKGameManagerState CurrentState { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable lastUsedPlayerID;
		[NullAllowed, Export("lastUsedPlayerID")]
		string LastUsedPlayerID { get; }

		// @property (readonly, assign, nonatomic) BOOL isInitialConnectionEstablished;
		[Export("isInitialConnectionEstablished")]
		bool IsInitialConnectionEstablished { get; }

		// -(instancetype _Nonnull)initWithSessionID:(NSString * _Nonnull)castSessionID __attribute__((objc_designated_initializer));
		[Export("initWithSessionID:")]
		[DesignatedInitializer]
		IntPtr Constructor(string castSessionID);

		// -(NSInteger)sendPlayerAvailableRequest:(id _Nullable)extraData;
		[Export("sendPlayerAvailableRequest:")]
		nint SendPlayerAvailableRequest([NullAllowed] NSObject extraData);

		// -(NSInteger)sendPlayerAvailableRequest:(id _Nullable)extraData playerID:(NSString * _Nonnull)playerID;
		[Export("sendPlayerAvailableRequest:playerID:")]
		nint SendPlayerAvailableRequest([NullAllowed] NSObject extraData, string playerID);

		// -(NSInteger)sendPlayerReadyRequest:(id _Nullable)extraData;
		[Export("sendPlayerReadyRequest:")]
		nint SendPlayerReadyRequest([NullAllowed] NSObject extraData);

		// -(NSInteger)sendPlayerReadyRequest:(id _Nullable)extraData playerID:(NSString * _Nonnull)playerID;
		[Export("sendPlayerReadyRequest:playerID:")]
		nint SendPlayerReadyRequest([NullAllowed] NSObject extraData, string playerID);

		// -(NSInteger)sendPlayerPlayingRequest:(id _Nullable)extraData;
		[Export("sendPlayerPlayingRequest:")]
		nint SendPlayerPlayingRequest([NullAllowed] NSObject extraData);

		// -(NSInteger)sendPlayerPlayingRequest:(id _Nullable)extraData playerID:(NSString * _Nonnull)playerID;
		[Export("sendPlayerPlayingRequest:playerID:")]
		nint SendPlayerPlayingRequest([NullAllowed] NSObject extraData, string playerID);

		// -(NSInteger)sendPlayerIdleRequest:(id _Nullable)extraData;
		[Export("sendPlayerIdleRequest:")]
		nint SendPlayerIdleRequest([NullAllowed] NSObject extraData);

		// -(NSInteger)sendPlayerIdleRequest:(id _Nullable)extraData playerID:(NSString * _Nonnull)playerID;
		[Export("sendPlayerIdleRequest:playerID:")]
		nint SendPlayerIdleRequest([NullAllowed] NSObject extraData, string playerID);

		// -(NSInteger)sendPlayerQuitRequest:(id _Nullable)extraData;
		[Export("sendPlayerQuitRequest:")]
		nint SendPlayerQuitRequest([NullAllowed] NSObject extraData);

		// -(NSInteger)sendPlayerQuitRequest:(id _Nullable)extraData playerID:(NSString * _Nonnull)playerID;
		[Export("sendPlayerQuitRequest:playerID:")]
		nint SendPlayerQuitRequest([NullAllowed] NSObject extraData, string playerID);

		// -(NSInteger)sendGameRequest:(id _Nullable)extraData;
		[Export("sendGameRequest:")]
		nint SendGameRequest([NullAllowed] NSObject extraData);

		// -(NSInteger)sendGameRequest:(id _Nullable)extraData playerID:(NSString * _Nonnull)playerID;
		[Export("sendGameRequest:playerID:")]
		nint SendGameRequest([NullAllowed] NSObject extraData, string playerID);

		// -(void)sendGameMessage:(id _Nullable)extraData;
		[Export("sendGameMessage:")]
		void SendGameMessage([NullAllowed] NSObject extraData);

		// -(void)sendGameMessage:(id _Nullable)extraData playerID:(NSString * _Nonnull)playerID;
		[Export("sendGameMessage:playerID:")]
		void SendGameMessage([NullAllowed] NSObject extraData, string playerID);
	}

	// @protocol GCKGameManagerChannelDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKGameManagerChannelDelegate
	{
		// @required -(void)gameManagerChannel:(GCKGameManagerChannel * _Nonnull)gameManagerChannel stateDidChangeTo:(id)currentState from:(id)previousState;
		[Abstract]
		[Export("gameManagerChannel:stateDidChangeTo:from:")]
		void GameManagerChannel(GCKGameManagerChannel gameManagerChannel, NSObject currentState, NSObject previousState);

		// @required -(void)gameManagerChannel:(GCKGameManagerChannel * _Nonnull)gameManagerChannel didReceiveGameMessage:(id _Nonnull)gameMessage forPlayerID:(NSString * _Nonnull)playerID;
		[Abstract]
		[Export("gameManagerChannel:didReceiveGameMessage:forPlayerID:")]
		void GameManagerChannel(GCKGameManagerChannel gameManagerChannel, NSObject gameMessage, string playerID);

		// @required -(void)gameManagerChannel:(GCKGameManagerChannel * _Nonnull)gameManagerChannel requestDidSucceedWithID:(NSInteger)requestID result:(GCKGameManagerResult * _Nonnull)result;
		[Abstract]
		[Export("gameManagerChannel:requestDidSucceedWithID:result:")]
		void GameManagerChannel(GCKGameManagerChannel gameManagerChannel, nint requestID, GCKGameManagerResult result);

		// @required -(void)gameManagerChannel:(GCKGameManagerChannel * _Nonnull)gameManagerChannel requestDidFailWithID:(NSInteger)requestID error:(GCKError * _Nonnull)error;
		[Abstract]
		[Export("gameManagerChannel:requestDidFailWithID:error:")]
		void GameManagerChannel(GCKGameManagerChannel gameManagerChannel, nint requestID, GCKError error);

		// @required -(void)gameManagerChannelDidConnect:(GCKGameManagerChannel * _Nonnull)gameManagerChannel;
		[Abstract]
		[Export("gameManagerChannelDidConnect:")]
		void GameManagerChannelDidConnect(GCKGameManagerChannel gameManagerChannel);

		// @required -(void)gameManagerChannel:(GCKGameManagerChannel * _Nonnull)gameManagerChannel didFailToConnectWithError:(GCKError * _Nonnull)error;
		[Abstract]
		[Export("gameManagerChannel:didFailToConnectWithError:")]
		void GameManagerChannel(GCKGameManagerChannel gameManagerChannel, GCKError error);
	}

	// @interface GCKGameManagerResult : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKGameManagerResult
	{
		// @property (readonly, assign, nonatomic) NSInteger requestID;
		[Export("requestID")]
		nint RequestID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull playerID;
		[Export("playerID")]
		string PlayerID { get; }

		// @property (readonly, copy, nonatomic) id _Nonnull extraData;
		[Export("extraData", ArgumentSemantic.Copy)]
		NSObject ExtraData { get; }
	}

	// @interface GCKGameManagerState : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKGameManagerState
	{
		// @property (readonly, assign, nonatomic) int lobbyState;
		[Export("lobbyState")]
		int LobbyState { get; }

		// @property (readonly, assign, nonatomic) int gameplayState;
		[Export("gameplayState")]
		int GameplayState { get; }

		// @property (readonly, copy, nonatomic) id _Nullable gameData;
		[NullAllowed, Export("gameData", ArgumentSemantic.Copy)]
		NSObject GameData { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable gameStatusText;
		[NullAllowed, Export("gameStatusText")]
		string GameStatusText { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull players;
		[Export("players", ArgumentSemantic.Strong)]
		NSObject[] Players { get; }

		// @property (readonly, nonatomic) NSArray * _Nonnull controllablePlayers;
		[Export("controllablePlayers")]
		NSObject[] ControllablePlayers { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull connectedPlayers;
		[Export("connectedPlayers", ArgumentSemantic.Strong)]
		NSObject[] ConnectedPlayers { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull connectedControllablePlayers;
		[Export("connectedControllablePlayers", ArgumentSemantic.Strong)]
		NSObject[] ConnectedControllablePlayers { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable applicationName;
		[NullAllowed, Export("applicationName")]
		string ApplicationName { get; }

		// @property (readonly, assign, nonatomic) NSInteger maxPlayers;
		[Export("maxPlayers")]
		nint MaxPlayers { get; }

		// -(id)getPlayer:(NSString * _Nonnull)playerID;
		[Export("getPlayer:")]
		NSObject GetPlayer(string playerID);

		// -(NSArray * _Nonnull)getPlayersInState:(id)playerState;
		[Export("getPlayersInState:")]
		NSObject[] GetPlayersInState(NSObject playerState);

		// -(BOOL)hasLobbyStateChanged:(GCKGameManagerState * _Nonnull)otherState;
		[Export("hasLobbyStateChanged:")]
		bool HasLobbyStateChanged(GCKGameManagerState otherState);

		// -(BOOL)hasGameplayStateChanged:(GCKGameManagerState * _Nonnull)otherState;
		[Export("hasGameplayStateChanged:")]
		bool HasGameplayStateChanged(GCKGameManagerState otherState);

		// -(BOOL)hasGameDataChanged:(GCKGameManagerState * _Nonnull)otherState;
		[Export("hasGameDataChanged:")]
		bool HasGameDataChanged(GCKGameManagerState otherState);

		// -(BOOL)hasGameStatusTextChanged:(GCKGameManagerState * _Nonnull)otherState;
		[Export("hasGameStatusTextChanged:")]
		bool HasGameStatusTextChanged(GCKGameManagerState otherState);

		// -(BOOL)hasPlayerChanged:(NSString * _Nonnull)playerId otherState:(GCKGameManagerState * _Nonnull)otherState;
		[Export("hasPlayerChanged:otherState:")]
		bool HasPlayerChanged(string playerId, GCKGameManagerState otherState);

		// -(BOOL)hasPlayerStateChanged:(NSString * _Nonnull)playerId otherState:(GCKGameManagerState * _Nonnull)otherState;
		[Export("hasPlayerStateChanged:otherState:")]
		bool HasPlayerStateChanged(string playerId, GCKGameManagerState otherState);

		// -(BOOL)hasPlayerDataChanged:(NSString * _Nonnull)playerId otherState:(GCKGameManagerState * _Nonnull)otherState;
		[Export("hasPlayerDataChanged:otherState:")]
		bool HasPlayerDataChanged(string playerId, GCKGameManagerState otherState);

		// -(NSArray<NSString *> * _Nonnull)getListOfChangedPlayers:(GCKGameManagerState * _Nonnull)otherState;
		[Export("getListOfChangedPlayers:")]
		string[] GetListOfChangedPlayers(GCKGameManagerState otherState);
	}

	// @interface GCKGenericChannel
	[BaseType(typeof(GCKCastChannel))]
	interface GCKGenericChannel
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		GCKGenericChannelDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<GCKGenericChannelDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithNamespace:(NSString * _Nonnull)protocolNamespace __attribute__((objc_designated_initializer));
		[Export("initWithNamespace:")]
		[DesignatedInitializer]
		IntPtr Constructor(string protocolNamespace);
	}

	// @protocol GCKGenericChannelDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKGenericChannelDelegate
	{
		// @required -(void)castChannel:(GCKGenericChannel * _Nonnull)channel didReceiveTextMessage:(NSString * _Nonnull)message withNamespace:(NSString * _Nonnull)protocolNamespace;
		[Abstract]
		[Export("castChannel:didReceiveTextMessage:withNamespace:")]
		void CastChannel(GCKGenericChannel channel, string message, string protocolNamespace);

		// @optional -(void)castChannelDidConnect:(GCKGenericChannel * _Nonnull)channel;
		[Export("castChannelDidConnect:")]
		void CastChannelDidConnect(GCKGenericChannel channel);

		// @optional -(void)castChannelDidDisconnect:(GCKGenericChannel * _Nonnull)channel;
		[Export("castChannelDidDisconnect:")]
		void CastChannelDidDisconnect(GCKGenericChannel channel);
	}

	partial interface Constants
	{
		// extern BOOL GCKAnalyticsLoggingEnabled __attribute__((visibility("default")));
		[Field("GCKAnalyticsLoggingEnabled", "__Internal")]
		nint GCKAnalyticsLoggingEnabled { get; }
	}

	// @interface GCKImage : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface GCKImage : INSCopying, INSCoding
	{
		// @property (readonly, nonatomic, strong) NSURL * _Nonnull URL;
		[Export("URL", ArgumentSemantic.Strong)]
		NSUrl URL { get; }

		// @property (readonly, assign, nonatomic) NSInteger width;
		[Export("width")]
		nint Width { get; }

		// @property (readonly, assign, nonatomic) NSInteger height;
		[Export("height")]
		nint Height { get; }

		// -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)URL width:(NSInteger)width height:(NSInteger)height;
		[Export("initWithURL:width:height:")]
		IntPtr Constructor(NSUrl URL, nint width, nint height);
	}

	// @interface GCKJSONUtils : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKJSONUtils
	{
		// +(id _Nonnull)parseJSON:(NSString * _Nonnull)json;
		[Static]
		[Export("parseJSON:")]
		NSObject ParseJSON(string json);

		// +(id _Nonnull)parseJSON:(NSString * _Nonnull)json error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("parseJSON:error:")]
		NSObject ParseJSON(string json, [NullAllowed] out NSError error);

		// +(NSString * _Nonnull)writeJSON:(id _Nonnull)object;
		[Static]
		[Export("writeJSON:")]
		string WriteJSON(NSObject @object);

		// +(BOOL)isJSONString:(NSString * _Nonnull)actual equivalentTo:(NSString * _Nonnull)expected;
		[Static]
		[Export("isJSONString:equivalentTo:")]
		bool IsJSONString(string actual, string expected);

		// +(BOOL)isJSONObject:(id _Nonnull)actual equivalentTo:(id _Nonnull)expected;
		[Static]
		[Export("isJSONObject:equivalentTo:")]
		bool IsJSONObject(NSObject actual, NSObject expected);
	}

	// @interface GCKLaunchOptions : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface GCKLaunchOptions : INSCopying, INSCoding
	{
		// @property (readwrite, copy, nonatomic) NSString * _Nullable languageCode;
		[NullAllowed, Export("languageCode")]
		string LanguageCode { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL relaunchIfRunning;
		[Export("relaunchIfRunning")]
		bool RelaunchIfRunning { get; set; }

		// -(instancetype _Nonnull)initWithRelaunchIfRunning:(BOOL)relaunchIfRunning;
		[Export("initWithRelaunchIfRunning:")]
		IntPtr Constructor(bool relaunchIfRunning);

		// -(instancetype _Nonnull)initWithLanguageCode:(NSString * _Nullable)languageCode relaunchIfRunning:(BOOL)relaunchIfRunning;
		[Export("initWithLanguageCode:relaunchIfRunning:")]
		IntPtr Constructor([NullAllowed] string languageCode, bool relaunchIfRunning);
	}

	// @interface GCKLogger : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKLogger
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		GCKLoggerDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<GCKLoggerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readwrite, nonatomic, strong) GCKLoggerFilter * _Nullable filter;
		[NullAllowed, Export("filter", ArgumentSemantic.Strong)]
		GCKLoggerFilter Filter { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL loggingEnabled;
		[Export("loggingEnabled")]
		bool LoggingEnabled { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL fileLoggingEnabled;
		[Export("fileLoggingEnabled")]
		bool FileLoggingEnabled { get; set; }

		// @property (assign, readwrite, nonatomic) unsigned long long maxLogFileSize;
		[Export("maxLogFileSize")]
		ulong MaxLogFileSize { get; set; }

		// @property (assign, readwrite, nonatomic) NSUInteger maxLogFileCount;
		[Export("maxLogFileCount")]
		nuint MaxLogFileCount { get; set; }

		// @property (assign, readwrite, nonatomic) int minimumLevel;
		[Export("minimumLevel")]
		int MinimumLevel { get; set; }

		// +(GCKLogger * _Nonnull)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		GCKLogger SharedInstance { get; }

		// -(void)logFromFunction:(const char * _Nonnull)function message:(NSString * _Nonnull)format, ... __attribute__((format(NSString, 2, 3)));
		[Internal]
		[Export("logFromFunction:message:", IsVariadic = true)]
		unsafe void LogFromFunction([PlainString] string function, string format, IntPtr varArgs);
	}

	// @protocol GCKLoggerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKLoggerDelegate
	{
		// @optional -(void)logFromFunction:(const char * _Nonnull)function message:(NSString * _Nonnull)message __attribute__((deprecated("Use -[GCKLoggerDelegate logMessage:fromFunction:]")));
		[Export("logFromFunction:message:")]
		unsafe void LogFromFunction([PlainString] string function, string message);

		// @optional -(void)logMessage:(NSString * _Nonnull)message fromFunction:(NSString * _Nonnull)function;
		[Export("logMessage:fromFunction:")]
		void LogMessage(string message, string function);
	}

	// @interface GCKLoggerFilter : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKLoggerFilter
	{
		// @property (assign, readwrite, nonatomic) BOOL exclusive;
		[Export("exclusive")]
		bool Exclusive { get; set; }

		// -(void)addClassNames:(NSArray<NSString *> * _Nonnull)classNames;
		[Export("addClassNames:")]
		void AddClassNames(string[] classNames);

		// -(void)addClassNames:(NSArray<NSString *> * _Nonnull)classNames minimumLogLevel:(GCKLoggerLevel)minimumLogLevel;
		[Export("addClassNames:minimumLogLevel:")]
		void AddClassNames(string[] classNames, GCKLoggerLevel minimumLogLevel);

		// -(void)addFunctionNames:(NSArray<NSString *> * _Nonnull)functionNames;
		[Export("addFunctionNames:")]
		void AddFunctionNames(string[] functionNames);

		// -(void)addFunctionNames:(NSArray<NSString *> * _Nonnull)functionNames minimumLogLevel:(GCKLoggerLevel)minimumLogLevel;
		[Export("addFunctionNames:minimumLogLevel:")]
		void AddFunctionNames(string[] functionNames, GCKLoggerLevel minimumLogLevel);

		// -(void)addMessagePatterns:(NSArray<NSString *> * _Nonnull)messagePatterns;
		[Export("addMessagePatterns:")]
		void AddMessagePatterns(string[] messagePatterns);

		// -(void)addMessagePatterns:(NSArray<NSString *> * _Nonnull)messagePatterns caseInsensitive:(BOOL)caseInsensitive;
		[Export("addMessagePatterns:caseInsensitive:")]
		void AddMessagePatterns(string[] messagePatterns, bool caseInsensitive);

		// -(void)reset;
		[Export("reset")]
		void Reset();
	}

	partial interface Constants
	{
		// extern const NSTimeInterval kGCKInvalidTimeInterval __attribute__((visibility("default")));
		[Field("kGCKInvalidTimeInterval", "__Internal")]
		double kGCKInvalidTimeInterval { get; }

		// extern NSString *const _Nonnull kGCKMediaDefaultReceiverApplicationID __attribute__((visibility("default")));
		[Field("kGCKMediaDefaultReceiverApplicationID", "__Internal")]
		NSString kGCKMediaDefaultReceiverApplicationID { get; }
	}

	// @interface GCKMediaControlChannel
	[BaseType(typeof(GCKCastChannel))]
	interface GCKMediaControlChannel
	{
		// @property (readonly, nonatomic, strong) GCKMediaStatus * _Nullable mediaStatus;
		[NullAllowed, Export("mediaStatus", ArgumentSemantic.Strong)]
		GCKMediaStatus MediaStatus { get; }

		// @property (readonly, assign, nonatomic) NSTimeInterval timeSinceLastMediaStatusUpdate;
		[Export("timeSinceLastMediaStatusUpdate")]
		double TimeSinceLastMediaStatusUpdate { get; }

		// @property (readonly, copy, nonatomic) GCKError * _Nullable lastError;
		[NullAllowed, Export("lastError", ArgumentSemantic.Copy)]
		GCKError LastError { get; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		GCKMediaControlChannelDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<GCKMediaControlChannelDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(NSInteger)loadMedia:(GCKMediaInformation * _Nonnull)mediaInfo;
		[Export("loadMedia:")]
		nint LoadMedia(GCKMediaInformation mediaInfo);

		// -(NSInteger)loadMedia:(GCKMediaInformation * _Nonnull)mediaInfo autoplay:(BOOL)autoplay;
		[Export("loadMedia:autoplay:")]
		nint LoadMedia(GCKMediaInformation mediaInfo, bool autoplay);

		// -(NSInteger)loadMedia:(GCKMediaInformation * _Nonnull)mediaInfo autoplay:(BOOL)autoplay playPosition:(NSTimeInterval)playPosition;
		[Export("loadMedia:autoplay:playPosition:")]
		nint LoadMedia(GCKMediaInformation mediaInfo, bool autoplay, double playPosition);

		// -(NSInteger)loadMedia:(GCKMediaInformation * _Nonnull)mediaInfo autoplay:(BOOL)autoplay playPosition:(NSTimeInterval)playPosition customData:(id _Nullable)customData;
		[Export("loadMedia:autoplay:playPosition:customData:")]
		nint LoadMedia(GCKMediaInformation mediaInfo, bool autoplay, double playPosition, [NullAllowed] NSObject customData);

		// -(NSInteger)loadMedia:(GCKMediaInformation * _Nonnull)mediaInfo autoplay:(BOOL)autoplay playPosition:(NSTimeInterval)playPosition activeTrackIDs:(NSArray<NSNumber *> * _Nullable)activeTrackIDs;
		[Export("loadMedia:autoplay:playPosition:activeTrackIDs:")]
		nint LoadMedia(GCKMediaInformation mediaInfo, bool autoplay, double playPosition, [NullAllowed] NSNumber[] activeTrackIDs);

		// -(NSInteger)loadMedia:(GCKMediaInformation * _Nonnull)mediaInfo autoplay:(BOOL)autoplay playPosition:(NSTimeInterval)playPosition activeTrackIDs:(NSArray<NSNumber *> * _Nullable)activeTrackIDs customData:(id _Nullable)customData;
		[Export("loadMedia:autoplay:playPosition:activeTrackIDs:customData:")]
		nint LoadMedia(GCKMediaInformation mediaInfo, bool autoplay, double playPosition, [NullAllowed] NSNumber[] activeTrackIDs, [NullAllowed] NSObject customData);

		// -(NSInteger)setActiveTrackIDs:(NSArray<NSNumber *> * _Nullable)activeTrackIDs;
		[Export("setActiveTrackIDs:")]
		nint SetActiveTrackIDs([NullAllowed] NSNumber[] activeTrackIDs);

		// -(NSInteger)setTextTrackStyle:(GCKMediaTextTrackStyle * _Nullable)textTrackStyle;
		[Export("setTextTrackStyle:")]
		nint SetTextTrackStyle([NullAllowed] GCKMediaTextTrackStyle textTrackStyle);

		// -(NSInteger)pause;
		[Export("pause")]
		nint Pause();

		// -(NSInteger)pauseWithCustomData:(id _Nullable)customData;
		[Export("pauseWithCustomData:")]
		nint PauseWithCustomData([NullAllowed] NSObject customData);

		// -(NSInteger)stop;
		[Export("stop")]
		nint Stop();

		// -(NSInteger)stopWithCustomData:(id _Nullable)customData;
		[Export("stopWithCustomData:")]
		nint StopWithCustomData([NullAllowed] NSObject customData);

		// -(NSInteger)play;
		[Export("play")]
		nint Play();

		// -(NSInteger)playWithCustomData:(id _Nullable)customData;
		[Export("playWithCustomData:")]
		nint PlayWithCustomData([NullAllowed] NSObject customData);

		// -(NSInteger)seekToTimeInterval:(NSTimeInterval)position;
		[Export("seekToTimeInterval:")]
		nint SeekToTimeInterval(double position);

		// -(NSInteger)seekToTimeInterval:(NSTimeInterval)position resumeState:(GCKMediaControlChannelResumeState)resumeState;
		[Export("seekToTimeInterval:resumeState:")]
		nint SeekToTimeInterval(double position, GCKMediaControlChannelResumeState resumeState);

		// -(NSInteger)seekToTimeInterval:(NSTimeInterval)position resumeState:(GCKMediaControlChannelResumeState)resumeState customData:(id _Nullable)customData;
		[Export("seekToTimeInterval:resumeState:customData:")]
		nint SeekToTimeInterval(double position, GCKMediaControlChannelResumeState resumeState, [NullAllowed] NSObject customData);

		// -(NSInteger)queueLoadItems:(NSArray * _Nonnull)queueItems startIndex:(NSUInteger)startIndex repeatMode:(GCKMediaRepeatMode)repeatMode;
		[Export("queueLoadItems:startIndex:repeatMode:")]
		nint QueueLoadItems(NSObject[] queueItems, nuint startIndex, GCKMediaRepeatMode repeatMode);

		// -(NSInteger)queueLoadItems:(NSArray * _Nonnull)queueItems startIndex:(NSUInteger)startIndex repeatMode:(GCKMediaRepeatMode)repeatMode customData:(id _Nullable)customData;
		[Export("queueLoadItems:startIndex:repeatMode:customData:")]
		nint QueueLoadItems(NSObject[] queueItems, nuint startIndex, GCKMediaRepeatMode repeatMode, [NullAllowed] NSObject customData);

		// -(NSInteger)queueLoadItems:(NSArray * _Nonnull)queueItems startIndex:(NSUInteger)startIndex playPosition:(NSTimeInterval)playPosition repeatMode:(GCKMediaRepeatMode)repeatMode customData:(id _Nullable)customData;
		[Export("queueLoadItems:startIndex:playPosition:repeatMode:customData:")]
		nint QueueLoadItems(NSObject[] queueItems, nuint startIndex, double playPosition, GCKMediaRepeatMode repeatMode, [NullAllowed] NSObject customData);

		// -(NSInteger)queueInsertItems:(NSArray * _Nonnull)queueItems beforeItemWithID:(NSUInteger)beforeItemID;
		[Export("queueInsertItems:beforeItemWithID:")]
		nint QueueInsertItems(NSObject[] queueItems, nuint beforeItemID);

		// -(NSInteger)queueInsertItems:(NSArray * _Nonnull)queueItems beforeItemWithID:(NSUInteger)beforeItemID customData:(id _Nullable)customData;
		[Export("queueInsertItems:beforeItemWithID:customData:")]
		nint QueueInsertItems(NSObject[] queueItems, nuint beforeItemID, [NullAllowed] NSObject customData);

		// -(NSInteger)queueInsertItem:(id)item beforeItemWithID:(NSUInteger)beforeItemID;
		[Export("queueInsertItem:beforeItemWithID:")]
		nint QueueInsertItem(NSObject item, nuint beforeItemID);

		// -(NSInteger)queueInsertAndPlayItem:(id)item beforeItemWithID:(NSUInteger)beforeItemID;
		[Export("queueInsertAndPlayItem:beforeItemWithID:")]
		nint QueueInsertAndPlayItem(NSObject item, nuint beforeItemID);

		// -(NSInteger)queueInsertAndPlayItem:(id)item beforeItemWithID:(NSUInteger)beforeItemID playPosition:(NSTimeInterval)playPosition customData:(id _Nullable)customData;
		[Export("queueInsertAndPlayItem:beforeItemWithID:playPosition:customData:")]
		nint QueueInsertAndPlayItem(NSObject item, nuint beforeItemID, double playPosition, [NullAllowed] NSObject customData);

		// -(NSInteger)queueUpdateItems:(NSArray * _Nonnull)queueItems;
		[Export("queueUpdateItems:")]
		nint QueueUpdateItems(NSObject[] queueItems);

		// -(NSInteger)queueUpdateItems:(NSArray * _Nonnull)queueItems customData:(id _Nullable)customData;
		[Export("queueUpdateItems:customData:")]
		nint QueueUpdateItems(NSObject[] queueItems, [NullAllowed] NSObject customData);

		// -(NSInteger)queueRemoveItemsWithIDs:(NSArray<NSNumber *> * _Nonnull)itemIDs;
		[Export("queueRemoveItemsWithIDs:")]
		nint QueueRemoveItemsWithIDs(NSNumber[] itemIDs);

		// -(NSInteger)queueRemoveItemsWithIDs:(NSArray<NSNumber *> * _Nonnull)itemIDs customData:(id _Nullable)customData;
		[Export("queueRemoveItemsWithIDs:customData:")]
		nint QueueRemoveItemsWithIDs(NSNumber[] itemIDs, [NullAllowed] NSObject customData);

		// -(NSInteger)queueRemoveItemWithID:(NSUInteger)itemID;
		[Export("queueRemoveItemWithID:")]
		nint QueueRemoveItemWithID(nuint itemID);

		// -(NSInteger)queueReorderItemsWithIDs:(NSArray<NSNumber *> * _Nonnull)queueItemIDs insertBeforeItemWithID:(NSUInteger)beforeItemID;
		[Export("queueReorderItemsWithIDs:insertBeforeItemWithID:")]
		nint QueueReorderItemsWithIDs(NSNumber[] queueItemIDs, nuint beforeItemID);

		// -(NSInteger)queueReorderItemsWithIDs:(NSArray<NSNumber *> * _Nonnull)queueItemIDs insertBeforeItemWithID:(NSUInteger)beforeItemID customData:(id _Nullable)customData;
		[Export("queueReorderItemsWithIDs:insertBeforeItemWithID:customData:")]
		nint QueueReorderItemsWithIDs(NSNumber[] queueItemIDs, nuint beforeItemID, [NullAllowed] NSObject customData);

		// -(NSInteger)queueMoveItemWithID:(NSUInteger)itemID beforeItemWithID:(NSUInteger)beforeItemID;
		[Export("queueMoveItemWithID:beforeItemWithID:")]
		nint QueueMoveItemWithID(nuint itemID, nuint beforeItemID);

		// -(NSInteger)queueJumpToItemWithID:(NSUInteger)itemID;
		[Export("queueJumpToItemWithID:")]
		nint QueueJumpToItemWithID(nuint itemID);

		// -(NSInteger)queueJumpToItemWithID:(NSUInteger)itemID customData:(id _Nullable)customData;
		[Export("queueJumpToItemWithID:customData:")]
		nint QueueJumpToItemWithID(nuint itemID, [NullAllowed] NSObject customData);

		// -(NSInteger)queueJumpToItemWithID:(NSUInteger)itemID playPosition:(NSTimeInterval)playPosition customData:(id _Nullable)customData;
		[Export("queueJumpToItemWithID:playPosition:customData:")]
		nint QueueJumpToItemWithID(nuint itemID, double playPosition, [NullAllowed] NSObject customData);

		// -(NSInteger)queueNextItem;
		[Export("queueNextItem")]
		nint QueueNextItem();

		// -(NSInteger)queuePreviousItem;
		[Export("queuePreviousItem")]
		nint QueuePreviousItem();

		// -(NSInteger)queueSetRepeatMode:(GCKMediaRepeatMode)repeatMode;
		[Export("queueSetRepeatMode:")]
		nint QueueSetRepeatMode(GCKMediaRepeatMode repeatMode);

		// -(NSInteger)setStreamVolume:(float)volume;
		[Export("setStreamVolume:")]
		nint SetStreamVolume(float volume);

		// -(NSInteger)setStreamVolume:(float)volume customData:(id _Nullable)customData;
		[Export("setStreamVolume:customData:")]
		nint SetStreamVolume(float volume, [NullAllowed] NSObject customData);

		// -(NSInteger)setStreamMuted:(BOOL)muted;
		[Export("setStreamMuted:")]
		nint SetStreamMuted(bool muted);

		// -(NSInteger)setStreamMuted:(BOOL)muted customData:(id _Nullable)customData;
		[Export("setStreamMuted:customData:")]
		nint SetStreamMuted(bool muted, [NullAllowed] NSObject customData);

		// -(NSInteger)requestStatus;
		[Export("requestStatus")]
		nint RequestStatus();

		// -(NSTimeInterval)approximateStreamPosition;
		[Export("approximateStreamPosition")]
		double ApproximateStreamPosition();

		// -(BOOL)cancelRequestWithID:(NSInteger)requestID;
		[Export("cancelRequestWithID:")]
		bool CancelRequestWithID(nint requestID);
	}

	// @protocol GCKMediaControlChannelDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKMediaControlChannelDelegate
	{
		// @optional -(void)mediaControlChannel:(GCKMediaControlChannel * _Nonnull)mediaControlChannel didCompleteLoadWithSessionID:(NSInteger)sessionID;
		[Export("mediaControlChannel:didCompleteLoadWithSessionID:")]
		void MediaControlChannelDidCompleteLoadWithSessionID(GCKMediaControlChannel mediaControlChannel, nint sessionID);

		// @optional -(void)mediaControlChannel:(GCKMediaControlChannel * _Nonnull)mediaControlChannel didFailToLoadMediaWithError:(GCKError * _Nonnull)error;
		[Export("mediaControlChannel:didFailToLoadMediaWithError:")]
		void MediaControlChannelDidFailToLoadMediaWithError(GCKMediaControlChannel mediaControlChannel, GCKError error);

		// @optional -(void)mediaControlChannelDidUpdateStatus:(GCKMediaControlChannel * _Nonnull)mediaControlChannel;
		[Export("mediaControlChannelDidUpdateStatus:")]
		void MediaControlChannelDidUpdateStatus(GCKMediaControlChannel mediaControlChannel);

		// @optional -(void)mediaControlChannelDidUpdateQueue:(GCKMediaControlChannel * _Nonnull)mediaControlChannel;
		[Export("mediaControlChannelDidUpdateQueue:")]
		void MediaControlChannelDidUpdateQueue(GCKMediaControlChannel mediaControlChannel);

		// @optional -(void)mediaControlChannelDidUpdatePreloadStatus:(GCKMediaControlChannel * _Nonnull)mediaControlChannel;
		[Export("mediaControlChannelDidUpdatePreloadStatus:")]
		void MediaControlChannelDidUpdatePreloadStatus(GCKMediaControlChannel mediaControlChannel);

		// @optional -(void)mediaControlChannelDidUpdateMetadata:(GCKMediaControlChannel * _Nonnull)mediaControlChannel;
		[Export("mediaControlChannelDidUpdateMetadata:")]
		void MediaControlChannelDidUpdateMetadata(GCKMediaControlChannel mediaControlChannel);

		// @optional -(void)mediaControlChannel:(GCKMediaControlChannel * _Nonnull)mediaControlChannel requestDidCompleteWithID:(NSInteger)requestID;
		[Export("mediaControlChannel:requestDidCompleteWithID:")]
		void MediaControlChannelRequestDidCompleteWithID(GCKMediaControlChannel mediaControlChannel, nint requestID);

		// @optional -(void)mediaControlChannel:(GCKMediaControlChannel * _Nonnull)mediaControlChannel didReplaceRequestWithID:(NSInteger)requestID;
		[Export("mediaControlChannel:didReplaceRequestWithID:")]
		void MediaControlChannelDidReplaceRequestWithID(GCKMediaControlChannel mediaControlChannel, nint requestID);

		// @optional -(void)mediaControlChannel:(GCKMediaControlChannel * _Nonnull)mediaControlChannel didCancelRequestWithID:(NSInteger)requestID;
		[Export("mediaControlChannel:didCancelRequestWithID:")]
		void MediaControlChannelDidCancelRequestWithID(GCKMediaControlChannel mediaControlChannel, nint requestID);

		// @optional -(void)mediaControlChannel:(GCKMediaControlChannel * _Nonnull)mediaControlChannel requestDidFailWithID:(NSInteger)requestID error:(GCKError * _Nonnull)error;
		[Export("mediaControlChannel:requestDidFailWithID:error:")]
		void MediaControlChannelRequestDidFailWithID(GCKMediaControlChannel mediaControlChannel, nint requestID, GCKError error);
	}

	// @interface GCKMediaInformation : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GCKMediaInformation : INSCopying
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull contentID;
		[Export("contentID")]
		string ContentID { get; }

		// @property (readonly, nonatomic) GCKMediaStreamType streamType;
		[Export("streamType")]
		GCKMediaStreamType StreamType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull contentType;
		[Export("contentType")]
		string ContentType { get; }

		// @property (readonly, nonatomic, strong) GCKMediaMetadata * _Nullable metadata;
		[NullAllowed, Export("metadata", ArgumentSemantic.Strong)]
		GCKMediaMetadata Metadata { get; }

		// @property (readonly, copy, nonatomic) NSArray<GCKAdBreakInfo *> * _Nullable adBreaks;
		[NullAllowed, Export("adBreaks", ArgumentSemantic.Copy)]
		GCKAdBreakInfo[] AdBreaks { get; }

		// @property (readonly, nonatomic) NSTimeInterval streamDuration;
		[Export("streamDuration")]
		double StreamDuration { get; }

		// @property (readonly, copy, nonatomic) NSArray<GCKMediaTrack *> * _Nullable mediaTracks;
		[NullAllowed, Export("mediaTracks", ArgumentSemantic.Copy)]
		GCKMediaTrack[] MediaTracks { get; }

		// @property (readonly, copy, nonatomic) GCKMediaTextTrackStyle * _Nullable textTrackStyle;
		[NullAllowed, Export("textTrackStyle", ArgumentSemantic.Copy)]
		GCKMediaTextTrackStyle TextTrackStyle { get; }

		// @property (readonly, nonatomic, strong) id _Nullable customData;
		[NullAllowed, Export("customData", ArgumentSemantic.Strong)]
		NSObject CustomData { get; }

		// -(instancetype _Nonnull)initWithContentID:(NSString * _Nonnull)contentID streamType:(GCKMediaStreamType)streamType contentType:(NSString * _Nonnull)contentType metadata:(GCKMediaMetadata * _Nullable)metadata streamDuration:(NSTimeInterval)streamDuration mediaTracks:(NSArray<GCKMediaTrack *> * _Nullable)mediaTracks textTrackStyle:(GCKMediaTextTrackStyle * _Nullable)textTrackStyle customData:(id _Nullable)customData;
		[Export("initWithContentID:streamType:contentType:metadata:streamDuration:mediaTracks:textTrackStyle:customData:")]
		IntPtr Constructor(string contentID, GCKMediaStreamType streamType, string contentType, [NullAllowed] GCKMediaMetadata metadata, double streamDuration, [NullAllowed] GCKMediaTrack[] mediaTracks, [NullAllowed] GCKMediaTextTrackStyle textTrackStyle, [NullAllowed] NSObject customData);

		// -(instancetype _Nonnull)initWithContentID:(NSString * _Nonnull)contentID streamType:(GCKMediaStreamType)streamType contentType:(NSString * _Nonnull)contentType metadata:(GCKMediaMetadata * _Nullable)metadata streamDuration:(NSTimeInterval)streamDuration customData:(id _Nullable)customData;
		[Export("initWithContentID:streamType:contentType:metadata:streamDuration:customData:")]
		IntPtr Constructor(string contentID, GCKMediaStreamType streamType, string contentType, [NullAllowed] GCKMediaMetadata metadata, double streamDuration, [NullAllowed] NSObject customData);

		// -(GCKMediaTrack * _Nullable)mediaTrackWithID:(NSInteger)trackID;
		[Export("mediaTrackWithID:")]
		[return: NullAllowed]
		GCKMediaTrack MediaTrackWithID(nint trackID);
	}

	partial interface Constants
	{
		// extern NSString *const _Nonnull kGCKMetadataKeyCreationDate __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyCreationDate", "__Internal")]
		NSString kGCKMetadataKeyCreationDate { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyReleaseDate __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyReleaseDate", "__Internal")]
		NSString kGCKMetadataKeyReleaseDate { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyBroadcastDate __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyBroadcastDate", "__Internal")]
		NSString kGCKMetadataKeyBroadcastDate { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyTitle __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyTitle", "__Internal")]
		NSString kGCKMetadataKeyTitle { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeySubtitle __attribute__((visibility("default")));
		[Field("kGCKMetadataKeySubtitle", "__Internal")]
		NSString kGCKMetadataKeySubtitle { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyArtist __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyArtist", "__Internal")]
		NSString kGCKMetadataKeyArtist { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyAlbumArtist __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyAlbumArtist", "__Internal")]
		NSString kGCKMetadataKeyAlbumArtist { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyAlbumTitle __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyAlbumTitle", "__Internal")]
		NSString kGCKMetadataKeyAlbumTitle { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyComposer __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyComposer", "__Internal")]
		NSString kGCKMetadataKeyComposer { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyDiscNumber __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyDiscNumber", "__Internal")]
		NSString kGCKMetadataKeyDiscNumber { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyTrackNumber __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyTrackNumber", "__Internal")]
		NSString kGCKMetadataKeyTrackNumber { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeySeasonNumber __attribute__((visibility("default")));
		[Field("kGCKMetadataKeySeasonNumber", "__Internal")]
		NSString kGCKMetadataKeySeasonNumber { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyEpisodeNumber __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyEpisodeNumber", "__Internal")]
		NSString kGCKMetadataKeyEpisodeNumber { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeySeriesTitle __attribute__((visibility("default")));
		[Field("kGCKMetadataKeySeriesTitle", "__Internal")]
		NSString kGCKMetadataKeySeriesTitle { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyStudio __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyStudio", "__Internal")]
		NSString kGCKMetadataKeyStudio { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyWidth __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyWidth", "__Internal")]
		NSString kGCKMetadataKeyWidth { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyHeight __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyHeight", "__Internal")]
		NSString kGCKMetadataKeyHeight { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyLocationName __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyLocationName", "__Internal")]
		NSString kGCKMetadataKeyLocationName { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyLocationLatitude __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyLocationLatitude", "__Internal")]
		NSString kGCKMetadataKeyLocationLatitude { get; }

		// extern NSString *const _Nonnull kGCKMetadataKeyLocationLongitude __attribute__((visibility("default")));
		[Field("kGCKMetadataKeyLocationLongitude", "__Internal")]
		NSString kGCKMetadataKeyLocationLongitude { get; }
	}

	// @interface GCKMediaMetadata : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GCKMediaMetadata : INSCopying
	{
		// @property (readonly, assign, nonatomic) GCKMediaMetadataType metadataType;
		[Export("metadataType", ArgumentSemantic.Assign)]
		GCKMediaMetadataType MetadataType { get; }

		// -(instancetype _Nonnull)initWithMetadataType:(GCKMediaMetadataType)metadataType;
		[Export("initWithMetadataType:")]
		IntPtr Constructor(GCKMediaMetadataType metadataType);

		// -(NSArray * _Nonnull)images;
		[Export("images")]
		NSObject[] Images { get; }

		// -(void)removeAllMediaImages;
		[Export("removeAllMediaImages")]
		void RemoveAllMediaImages();

		// -(void)addImage:(GCKImage * _Nonnull)image;
		[Export("addImage:")]
		void AddImage(GCKImage image);

		// -(BOOL)containsKey:(NSString * _Nonnull)key;
		[Export("containsKey:")]
		bool ContainsKey(string key);

		// -(NSArray<NSString *> * _Nonnull)allKeys;
		[Export("allKeys")]
		string[] AllKeys { get; }

		// -(id _Nullable)objectForKey:(NSString * _Nonnull)key;
		[Export("objectForKey:")]
		[return: NullAllowed]
		NSObject ObjectForKey(string key);

		// -(void)setString:(NSString * _Nonnull)value forKey:(NSString * _Nonnull)key;
		[Export("setString:forKey:")]
		void SetString(string value, string key);

		// -(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key;
		[Export("stringForKey:")]
		[return: NullAllowed]
		string StringForKey(string key);

		// -(void)setInteger:(NSInteger)value forKey:(NSString * _Nonnull)key;
		[Export("setInteger:forKey:")]
		void SetInteger(nint value, string key);

		// -(NSInteger)integerForKey:(NSString * _Nonnull)key;
		[Export("integerForKey:")]
		nint IntegerForKey(string key);

		// -(NSInteger)integerForKey:(NSString * _Nonnull)key defaultValue:(NSInteger)defaultValue;
		[Export("integerForKey:defaultValue:")]
		nint IntegerForKey(string key, nint defaultValue);

		// -(void)setDouble:(double)value forKey:(NSString * _Nonnull)key;
		[Export("setDouble:forKey:")]
		void SetDouble(double value, string key);

		// -(double)doubleForKey:(NSString * _Nonnull)key;
		[Export("doubleForKey:")]
		double DoubleForKey(string key);

		// -(double)doubleForKey:(NSString * _Nonnull)key defaultValue:(double)defaultValue;
		[Export("doubleForKey:defaultValue:")]
		double DoubleForKey(string key, double defaultValue);

		// -(void)setDate:(NSDate * _Nonnull)date forKey:(NSString * _Nonnull)key;
		[Export("setDate:forKey:")]
		void SetDate(NSDate date, string key);

		// -(NSDate * _Nullable)dateForKey:(NSString * _Nonnull)key;
		[Export("dateForKey:")]
		[return: NullAllowed]
		NSDate DateForKey(string key);

		// -(NSString * _Nullable)dateAsStringForKey:(NSString * _Nonnull)key;
		[Export("dateAsStringForKey:")]
		[return: NullAllowed]
		string DateAsStringForKey(string key);
	}

	partial interface Constants
	{
		// extern const NSUInteger kGCKMediaQueueInvalidItemID __attribute__((visibility("default")));
		[Field("kGCKMediaQueueInvalidItemID", "__Internal")]
		nuint kGCKMediaQueueInvalidItemID { get; }
	}

	// @interface GCKMediaQueueItem : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GCKMediaQueueItem : INSCopying
	{
		// @property (readonly, nonatomic, strong) GCKMediaInformation * _Nonnull mediaInformation;
		[Export("mediaInformation", ArgumentSemantic.Strong)]
		GCKMediaInformation MediaInformation { get; }

		// @property (readonly, assign, nonatomic) NSUInteger itemID;
		[Export("itemID")]
		nuint ItemID { get; }

		// @property (readonly, assign, nonatomic) BOOL autoplay;
		[Export("autoplay")]
		bool Autoplay { get; }

		// @property (readonly, assign, nonatomic) NSTimeInterval startTime;
		[Export("startTime")]
		double StartTime { get; }

		// @property (readonly, assign, nonatomic) NSTimeInterval playbackDuration;
		[Export("playbackDuration")]
		double PlaybackDuration { get; }

		// @property (readonly, assign, nonatomic) NSTimeInterval preloadTime;
		[Export("preloadTime")]
		double PreloadTime { get; }

		// @property (readonly, nonatomic, strong) NSArray<NSNumber *> * _Nonnull activeTrackIDs;
		[Export("activeTrackIDs", ArgumentSemantic.Strong)]
		NSNumber[] ActiveTrackIDs { get; }

		// @property (readonly, nonatomic, strong) id _Nonnull customData;
		[Export("customData", ArgumentSemantic.Strong)]
		NSObject CustomData { get; }

		// -(instancetype _Nonnull)initWithMediaInformation:(GCKMediaInformation * _Nonnull)mediaInformation autoplay:(BOOL)autoplay startTime:(NSTimeInterval)startTime preloadTime:(NSTimeInterval)preloadTime activeTrackIDs:(NSArray<NSNumber *> * _Nullable)activeTrackIDs customData:(id _Nullable)customData;
		[Export("initWithMediaInformation:autoplay:startTime:preloadTime:activeTrackIDs:customData:")]
		IntPtr Constructor(GCKMediaInformation mediaInformation, bool autoplay, double startTime, double preloadTime, [NullAllowed] NSNumber[] activeTrackIDs, [NullAllowed] NSObject customData);

		// -(instancetype _Nonnull)initWithMediaInformation:(GCKMediaInformation * _Nonnull)mediaInformation autoplay:(BOOL)autoplay startTime:(NSTimeInterval)startTime playbackDuration:(NSTimeInterval)playbackDuration preloadTime:(NSTimeInterval)preloadTime activeTrackIDs:(NSArray<NSNumber *> * _Nullable)activeTrackIDs customData:(id _Nullable)customData;
		[Export("initWithMediaInformation:autoplay:startTime:playbackDuration:preloadTime:activeTrackIDs:customData:")]
		IntPtr Constructor(GCKMediaInformation mediaInformation, bool autoplay, double startTime, double playbackDuration, double preloadTime, [NullAllowed] NSNumber[] activeTrackIDs, [NullAllowed] NSObject customData);

		// -(void)clearItemID;
		[Export("clearItemID")]
		void ClearItemID();

		// -(instancetype _Nonnull)mediaQueueItemModifiedWithBlock:(void (^ _Nonnull)(GCKMediaQueueItemBuilder * _Nonnull))block;
		[Export("mediaQueueItemModifiedWithBlock:")]
		GCKMediaQueueItem MediaQueueItemModifiedWithBlock(Action<GCKMediaQueueItemBuilder> block);
	}

	// @interface GCKMediaQueueItemBuilder : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKMediaQueueItemBuilder
	{
		// @property (readwrite, copy, nonatomic) GCKMediaInformation * _Nullable mediaInformation;
		[NullAllowed, Export("mediaInformation", ArgumentSemantic.Copy)]
		GCKMediaInformation MediaInformation { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL autoplay;
		[Export("autoplay")]
		bool Autoplay { get; set; }

		// @property (assign, readwrite, nonatomic) NSTimeInterval startTime;
		[Export("startTime")]
		double StartTime { get; set; }

		// @property (assign, readwrite, nonatomic) NSTimeInterval playbackDuration;
		[Export("playbackDuration")]
		double PlaybackDuration { get; set; }

		// @property (assign, readwrite, nonatomic) NSTimeInterval preloadTime;
		[Export("preloadTime")]
		double PreloadTime { get; set; }

		// @property (readwrite, copy, nonatomic) NSArray<NSNumber *> * _Nullable activeTrackIDs;
		[NullAllowed, Export("activeTrackIDs", ArgumentSemantic.Copy)]
		NSNumber[] ActiveTrackIDs { get; set; }

		// @property (readwrite, copy, nonatomic) id _Nullable customData;
		[NullAllowed, Export("customData", ArgumentSemantic.Copy)]
		NSObject CustomData { get; set; }

		// -(instancetype _Nonnull)initWithMediaQueueItem:(GCKMediaQueueItem * _Nullable)item;
		[Export("initWithMediaQueueItem:")]
		IntPtr Constructor([NullAllowed] GCKMediaQueueItem item);

		// -(GCKMediaQueueItem * _Nonnull)build;
		[Export("build")]
		GCKMediaQueueItem Build();
	}

	partial interface Constants
	{
		// extern const NSInteger kGCKMediaCommandPause __attribute__((visibility("default")));
		[Field("kGCKMediaCommandPause", "__Internal")]
		nint kGCKMediaCommandPause { get; }

		// extern const NSInteger kGCKMediaCommandSeek __attribute__((visibility("default")));
		[Field("kGCKMediaCommandSeek", "__Internal")]
		nint kGCKMediaCommandSeek { get; }

		// extern const NSInteger kGCKMediaCommandSetVolume __attribute__((visibility("default")));
		[Field("kGCKMediaCommandSetVolume", "__Internal")]
		nint kGCKMediaCommandSetVolume { get; }

		// extern const NSInteger kGCKMediaCommandToggleMute __attribute__((visibility("default")));
		[Field("kGCKMediaCommandToggleMute", "__Internal")]
		nint kGCKMediaCommandToggleMute { get; }

		// extern const NSInteger kGCKMediaCommandSkipForward __attribute__((visibility("default")));
		[Field("kGCKMediaCommandSkipForward", "__Internal")]
		nint kGCKMediaCommandSkipForward { get; }

		// extern const NSInteger kGCKMediaCommandSkipBackward __attribute__((visibility("default")));
		[Field("kGCKMediaCommandSkipBackward", "__Internal")]
		nint kGCKMediaCommandSkipBackward { get; }

		// extern const NSInteger kGCKMediaCommandQueueNext __attribute__((visibility("default")));
		[Field("kGCKMediaCommandQueueNext", "__Internal")]
		nint kGCKMediaCommandQueueNext { get; }

		// extern const NSInteger kGCKMediaCommandQueuePrevious __attribute__((visibility("default")));
		[Field("kGCKMediaCommandQueuePrevious", "__Internal")]
		nint kGCKMediaCommandQueuePrevious { get; }
	}

	// @interface GCKMediaStatus : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GCKMediaStatus : INSCopying
	{
		// @property (readonly, assign, nonatomic) NSInteger mediaSessionID;
		[Export("mediaSessionID")]
		nint MediaSessionID { get; }

		// @property (readonly, assign, nonatomic) GCKMediaPlayerState playerState;
		[Export("playerState", ArgumentSemantic.Assign)]
		GCKMediaPlayerState PlayerState { get; }

		// @property (readonly, assign, nonatomic) BOOL playingAd;
		[Export("playingAd")]
		bool PlayingAd { get; }

		// @property (readonly, assign, nonatomic) GCKMediaPlayerIdleReason idleReason;
		[Export("idleReason", ArgumentSemantic.Assign)]
		GCKMediaPlayerIdleReason IdleReason { get; }

		// @property (readonly, assign, nonatomic) float playbackRate;
		[Export("playbackRate")]
		float PlaybackRate { get; }

		// @property (readonly, nonatomic, strong) GCKMediaInformation * _Nullable mediaInformation;
		[NullAllowed, Export("mediaInformation", ArgumentSemantic.Strong)]
		GCKMediaInformation MediaInformation { get; }

		// @property (readonly, assign, nonatomic) NSTimeInterval streamPosition;
		[Export("streamPosition")]
		double StreamPosition { get; }

		// @property (readonly, assign, nonatomic) float volume;
		[Export("volume")]
		float Volume { get; }

		// @property (readonly, assign, nonatomic) BOOL isMuted;
		[Export("isMuted")]
		bool IsMuted { get; }

		// @property (readonly, assign, nonatomic) GCKMediaRepeatMode queueRepeatMode;
		[Export("queueRepeatMode", ArgumentSemantic.Assign)]
		GCKMediaRepeatMode QueueRepeatMode { get; }

		// @property (readonly, assign, nonatomic) NSUInteger currentItemID;
		[Export("currentItemID")]
		nuint CurrentItemID { get; }

		// @property (readonly, assign, nonatomic) BOOL queueHasCurrentItem;
		[Export("queueHasCurrentItem")]
		bool QueueHasCurrentItem { get; }

		// @property (readonly, assign, nonatomic) GCKMediaQueueItem * _Nullable currentQueueItem;
		[NullAllowed, Export("currentQueueItem", ArgumentSemantic.Assign)]
		GCKMediaQueueItem CurrentQueueItem { get; }

		// -(BOOL)queueHasNextItem;
		[Export("queueHasNextItem")]
		bool QueueHasNextItem();

		// @property (readonly, assign, nonatomic) GCKMediaQueueItem * _Nullable nextQueueItem;
		[NullAllowed, Export("nextQueueItem", ArgumentSemantic.Assign)]
		GCKMediaQueueItem NextQueueItem { get; }

		// @property (readonly, assign, nonatomic) BOOL queueHasPreviousItem;
		[Export("queueHasPreviousItem")]
		bool QueueHasPreviousItem { get; }

		// @property (readonly, assign, nonatomic) BOOL queueHasLoadingItem;
		[Export("queueHasLoadingItem")]
		bool QueueHasLoadingItem { get; }

		// @property (readonly, assign, nonatomic) NSUInteger preloadedItemID;
		[Export("preloadedItemID")]
		nuint PreloadedItemID { get; }

		// @property (readonly, assign, nonatomic) NSUInteger loadingItemID;
		[Export("loadingItemID")]
		nuint LoadingItemID { get; }

		// @property (readonly, nonatomic, strong) NSArray<NSNumber *> * _Nullable activeTrackIDs;
		[NullAllowed, Export("activeTrackIDs", ArgumentSemantic.Strong)]
		NSNumber[] ActiveTrackIDs { get; }

		// @property (readonly, nonatomic, strong) id _Nullable customData;
		[NullAllowed, Export("customData", ArgumentSemantic.Strong)]
		NSObject CustomData { get; }

		// -(instancetype _Nonnull)initWithSessionID:(NSInteger)mediaSessionID mediaInformation:(GCKMediaInformation * _Nullable)mediaInformation;
		[Export("initWithSessionID:mediaInformation:")]
		IntPtr Constructor(nint mediaSessionID, [NullAllowed] GCKMediaInformation mediaInformation);

		// -(BOOL)isMediaCommandSupported:(NSInteger)command;
		[Export("isMediaCommandSupported:")]
		bool IsMediaCommandSupported(nint command);

		// -(NSUInteger)queueItemCount;
		[Export("queueItemCount")]
		nuint QueueItemCount { get; }

		// -(GCKMediaQueueItem * _Nullable)queueItemAtIndex:(NSUInteger)index;
		[Export("queueItemAtIndex:")]
		[return: NullAllowed]
		GCKMediaQueueItem QueueItemAtIndex(nuint index);

		// -(GCKMediaQueueItem * _Nullable)queueItemWithItemID:(NSUInteger)itemID;
		[Export("queueItemWithItemID:")]
		[return: NullAllowed]
		GCKMediaQueueItem QueueItemWithItemID(nuint itemID);

		// -(NSInteger)queueIndexForItemID:(NSUInteger)itemID;
		[Export("queueIndexForItemID:")]
		nint QueueIndexForItemID(nuint itemID);
	}

	// @interface GCKMediaTextTrackStyle : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GCKMediaTextTrackStyle : INSCopying
	{
		// +(instancetype _Nonnull)createDefault;
		[Static]
		[Export("createDefault")]
		GCKMediaTextTrackStyle CreateDefault();

		// @property (assign, readwrite, nonatomic) CGFloat fontScale;
		[Export("fontScale")]
		nfloat FontScale { get; set; }

		// @property (readwrite, copy, nonatomic) GCKColor * _Nullable foregroundColor;
		[NullAllowed, Export("foregroundColor", ArgumentSemantic.Copy)]
		GCKColor ForegroundColor { get; set; }

		// @property (readwrite, copy, nonatomic) GCKColor * _Nullable backgroundColor;
		[NullAllowed, Export("backgroundColor", ArgumentSemantic.Copy)]
		GCKColor BackgroundColor { get; set; }

		// @property (assign, readwrite, nonatomic) GCKMediaTextTrackStyleEdgeType edgeType;
		[Export("edgeType", ArgumentSemantic.Assign)]
		GCKMediaTextTrackStyleEdgeType EdgeType { get; set; }

		// @property (readwrite, copy, nonatomic) GCKColor * _Nullable edgeColor;
		[NullAllowed, Export("edgeColor", ArgumentSemantic.Copy)]
		GCKColor EdgeColor { get; set; }

		// @property (assign, readwrite, nonatomic) GCKMediaTextTrackStyleWindowType windowType;
		[Export("windowType", ArgumentSemantic.Assign)]
		GCKMediaTextTrackStyleWindowType WindowType { get; set; }

		// @property (readwrite, copy, nonatomic) GCKColor * _Nullable windowColor;
		[NullAllowed, Export("windowColor", ArgumentSemantic.Copy)]
		GCKColor WindowColor { get; set; }

		// @property (assign, readwrite, nonatomic) CGFloat windowRoundedCornerRadius;
		[Export("windowRoundedCornerRadius")]
		nfloat WindowRoundedCornerRadius { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable fontFamily;
		[NullAllowed, Export("fontFamily")]
		string FontFamily { get; set; }

		// @property (assign, readwrite, nonatomic) GCKMediaTextTrackStyleFontGenericFamily fontGenericFamily;
		[Export("fontGenericFamily", ArgumentSemantic.Assign)]
		GCKMediaTextTrackStyleFontGenericFamily FontGenericFamily { get; set; }

		// @property (assign, readwrite, nonatomic) GCKMediaTextTrackStyleFontStyle fontStyle;
		[Export("fontStyle", ArgumentSemantic.Assign)]
		GCKMediaTextTrackStyleFontStyle FontStyle { get; set; }

		// @property (readwrite, nonatomic, strong) id _Nullable customData;
		[NullAllowed, Export("customData", ArgumentSemantic.Strong)]
		NSObject CustomData { get; set; }
	}

	// @interface GCKMediaTrack : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface GCKMediaTrack : INSCopying, INSCoding
	{
		// -(instancetype _Nonnull)initWithIdentifier:(NSInteger)identifier contentIdentifier:(NSString * _Nullable)contentIdentifier contentType:(NSString * _Nonnull)contentType type:(GCKMediaTrackType)type textSubtype:(GCKMediaTextTrackSubtype)textSubtype name:(NSString * _Nullable)name languageCode:(NSString * _Nullable)languageCode customData:(id _Nullable)customData;
		[Export("initWithIdentifier:contentIdentifier:contentType:type:textSubtype:name:languageCode:customData:")]
		IntPtr Constructor(nint identifier, [NullAllowed] string contentIdentifier, string contentType, GCKMediaTrackType type, GCKMediaTextTrackSubtype textSubtype, [NullAllowed] string name, [NullAllowed] string languageCode, [NullAllowed] NSObject customData);

		// @property (readonly, assign, nonatomic) NSInteger identifier;
		[Export("identifier")]
		nint Identifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable contentIdentifier;
		[NullAllowed, Export("contentIdentifier")]
		string ContentIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull contentType;
		[Export("contentType")]
		string ContentType { get; }

		// @property (readonly, assign, nonatomic) GCKMediaTrackType type;
		[Export("type", ArgumentSemantic.Assign)]
		GCKMediaTrackType Type { get; }

		// @property (readonly, assign, nonatomic) GCKMediaTextTrackSubtype textSubtype;
		[Export("textSubtype", ArgumentSemantic.Assign)]
		GCKMediaTextTrackSubtype TextSubtype { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable languageCode;
		[NullAllowed, Export("languageCode")]
		string LanguageCode { get; }

		// @property (readonly, nonatomic, strong) id _Nullable customData;
		[NullAllowed, Export("customData", ArgumentSemantic.Strong)]
		NSObject CustomData { get; }
	}

	// @interface GCKMultizoneDevice : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GCKMultizoneDevice : INSCopying
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull deviceID;
		[Export("deviceID")]
		string DeviceID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull friendlyName;
		[Export("friendlyName")]
		string FriendlyName { get; }

		// @property (assign, readwrite, nonatomic) NSInteger capabilities;
		[Export("capabilities")]
		nint Capabilities { get; set; }

		// @property (assign, readwrite, nonatomic) float volumeLevel;
		[Export("volumeLevel")]
		float VolumeLevel { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL muted;
		[Export("muted")]
		bool Muted { get; set; }

		// -(instancetype _Nonnull)initWithJSONObject:(id _Nonnull)JSONObject;
		[Export("initWithJSONObject:")]
		IntPtr Constructor(NSObject JSONObject);

		// -(instancetype _Nonnull)initWithDeviceID:(NSString * _Nonnull)deviceID friendlyName:(NSString * _Nonnull)friendlyName capabilities:(NSInteger)capabilities volumeLevel:(float)volume muted:(BOOL)muted;
		[Export("initWithDeviceID:friendlyName:capabilities:volumeLevel:muted:")]
		IntPtr Constructor(string deviceID, string friendlyName, nint capabilities, float volume, bool muted);
	}

	// @interface GCKMultizoneStatus : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GCKMultizoneStatus : INSCopying
	{
		// @property (readwrite, copy, nonatomic) NSArray<GCKMultizoneDevice *> * _Nonnull devices;
		[Export("devices", ArgumentSemantic.Copy)]
		GCKMultizoneDevice[] Devices { get; set; }

		// -(instancetype _Nonnull)initWithJSONObject:(id _Nonnull)JSONObject;
		[Export("initWithJSONObject:")]
		IntPtr Constructor(NSObject JSONObject);

		// -(instancetype _Nonnull)initWithDevices:(NSArray<GCKMultizoneDevice *> * _Nonnull)devices;
		[Export("initWithDevices:")]
		IntPtr Constructor(GCKMultizoneDevice[] devices);
	}

	// @interface GCKPlayerInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKPlayerInfo
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull playerID;
		[Export("playerID")]
		string PlayerID { get; }

		// @property (readonly, assign, nonatomic) int playerState;
		[Export("playerState")]
		int PlayerState { get; }

		// @property (readonly, copy, nonatomic) id _Nullable playerData;
		[NullAllowed, Export("playerData", ArgumentSemantic.Copy)]
		NSObject PlayerData { get; }

		// @property (readonly, assign, nonatomic) BOOL isConnected;
		[Export("isConnected")]
		bool IsConnected { get; }

		// @property (readonly, assign, nonatomic) BOOL isControllable;
		[Export("isControllable")]
		bool IsControllable { get; }
	}

	partial interface Constants
	{
		// extern NSString *const _Nonnull kGCKKeyConnected __attribute__((visibility("default")));
		[Field("kGCKKeyConnected", "__Internal")]
		NSString kGCKKeyConnected { get; }
	}

	// @interface GCKRemoteMediaClient : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKRemoteMediaClient
	{
		// @property (readonly, assign, nonatomic) BOOL connected;
		[Export("connected")]
		bool Connected { get; }

		// @property (readonly, nonatomic, strong) GCKMediaStatus * _Nullable mediaStatus;
		[NullAllowed, Export("mediaStatus", ArgumentSemantic.Strong)]
		GCKMediaStatus MediaStatus { get; }

		// @property (readonly, assign, nonatomic) NSTimeInterval timeSinceLastMediaStatusUpdate;
		[Export("timeSinceLastMediaStatusUpdate")]
		double TimeSinceLastMediaStatusUpdate { get; }

		// -(void)addListener:(id<GCKRemoteMediaClientListener> _Nonnull)listener;
		[Export("addListener:")]
		void AddListener(GCKRemoteMediaClientListener listener);

		// -(void)removeListener:(id<GCKRemoteMediaClientListener> _Nonnull)listener;
		[Export("removeListener:")]
		void RemoveListener(GCKRemoteMediaClientListener listener);

		[Wrap("WeakAdInfoParserDelegate")]
		[NullAllowed]
		GCKRemoteMediaClientAdInfoParserDelegate AdInfoParserDelegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<GCKRemoteMediaClientAdInfoParserDelegate> _Nullable adInfoParserDelegate;
		[NullAllowed, Export("adInfoParserDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAdInfoParserDelegate { get; set; }

		// -(GCKRequest * _Nonnull)loadMedia:(GCKMediaInformation * _Nonnull)mediaInfo;
		[Export("loadMedia:")]
		GCKRequest LoadMedia(GCKMediaInformation mediaInfo);

		// -(GCKRequest * _Nonnull)loadMedia:(GCKMediaInformation * _Nonnull)mediaInfo autoplay:(BOOL)autoplay;
		[Export("loadMedia:autoplay:")]
		GCKRequest LoadMedia(GCKMediaInformation mediaInfo, bool autoplay);

		// -(GCKRequest * _Nonnull)loadMedia:(GCKMediaInformation * _Nonnull)mediaInfo autoplay:(BOOL)autoplay playPosition:(NSTimeInterval)playPosition;
		[Export("loadMedia:autoplay:playPosition:")]
		GCKRequest LoadMedia(GCKMediaInformation mediaInfo, bool autoplay, double playPosition);

		// -(GCKRequest * _Nonnull)loadMedia:(GCKMediaInformation * _Nonnull)mediaInfo autoplay:(BOOL)autoplay playPosition:(NSTimeInterval)playPosition customData:(id _Nullable)customData;
		[Export("loadMedia:autoplay:playPosition:customData:")]
		GCKRequest LoadMedia(GCKMediaInformation mediaInfo, bool autoplay, double playPosition, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)loadMedia:(GCKMediaInformation * _Nonnull)mediaInfo autoplay:(BOOL)autoplay playPosition:(NSTimeInterval)playPosition activeTrackIDs:(NSArray<NSNumber *> * _Nullable)activeTrackIDs;
		[Export("loadMedia:autoplay:playPosition:activeTrackIDs:")]
		GCKRequest LoadMedia(GCKMediaInformation mediaInfo, bool autoplay, double playPosition, [NullAllowed] NSNumber[] activeTrackIDs);

		// -(GCKRequest * _Nonnull)loadMedia:(GCKMediaInformation * _Nonnull)mediaInfo autoplay:(BOOL)autoplay playPosition:(NSTimeInterval)playPosition activeTrackIDs:(NSArray<NSNumber *> * _Nullable)activeTrackIDs customData:(id _Nullable)customData;
		[Export("loadMedia:autoplay:playPosition:activeTrackIDs:customData:")]
		GCKRequest LoadMedia(GCKMediaInformation mediaInfo, bool autoplay, double playPosition, [NullAllowed] NSNumber[] activeTrackIDs, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)setActiveTrackIDs:(NSArray<NSNumber *> * _Nullable)activeTrackIDs;
		[Export("setActiveTrackIDs:")]
		GCKRequest SetActiveTrackIDs([NullAllowed] NSNumber[] activeTrackIDs);

		// -(GCKRequest * _Nonnull)setTextTrackStyle:(GCKMediaTextTrackStyle * _Nullable)textTrackStyle;
		[Export("setTextTrackStyle:")]
		GCKRequest SetTextTrackStyle([NullAllowed] GCKMediaTextTrackStyle textTrackStyle);

		// -(GCKRequest * _Nonnull)pause;
		[Export("pause")]
		GCKRequest Pause();

		// -(GCKRequest * _Nonnull)pauseWithCustomData:(id _Nullable)customData;
		[Export("pauseWithCustomData:")]
		GCKRequest PauseWithCustomData([NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)stop;
		[Export("stop")]
		GCKRequest Stop();

		// -(GCKRequest * _Nonnull)stopWithCustomData:(id _Nullable)customData;
		[Export("stopWithCustomData:")]
		GCKRequest StopWithCustomData([NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)play;
		[Export("play")]
		GCKRequest Play();

		// -(GCKRequest * _Nonnull)playWithCustomData:(id _Nullable)customData;
		[Export("playWithCustomData:")]
		GCKRequest PlayWithCustomData([NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)seekToTimeInterval:(NSTimeInterval)position;
		[Export("seekToTimeInterval:")]
		GCKRequest SeekToTimeInterval(double position);

		// -(GCKRequest * _Nonnull)seekToTimeInterval:(NSTimeInterval)position resumeState:(GCKMediaResumeState)resumeState;
		[Export("seekToTimeInterval:resumeState:")]
		GCKRequest SeekToTimeInterval(double position, GCKMediaResumeState resumeState);

		// -(GCKRequest * _Nonnull)seekToTimeInterval:(NSTimeInterval)position resumeState:(GCKMediaResumeState)resumeState customData:(id _Nullable)customData;
		[Export("seekToTimeInterval:resumeState:customData:")]
		GCKRequest SeekToTimeInterval(double position, GCKMediaResumeState resumeState, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)queueLoadItems:(NSArray<GCKMediaQueueItem *> * _Nonnull)queueItems startIndex:(NSUInteger)startIndex repeatMode:(GCKMediaRepeatMode)repeatMode;
		[Export("queueLoadItems:startIndex:repeatMode:")]
		GCKRequest QueueLoadItems(GCKMediaQueueItem[] queueItems, nuint startIndex, GCKMediaRepeatMode repeatMode);

		// -(GCKRequest * _Nonnull)queueLoadItems:(NSArray<GCKMediaQueueItem *> * _Nonnull)queueItems startIndex:(NSUInteger)startIndex repeatMode:(GCKMediaRepeatMode)repeatMode customData:(id _Nullable)customData;
		[Export("queueLoadItems:startIndex:repeatMode:customData:")]
		GCKRequest QueueLoadItems(GCKMediaQueueItem[] queueItems, nuint startIndex, GCKMediaRepeatMode repeatMode, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)queueLoadItems:(NSArray<GCKMediaQueueItem *> * _Nonnull)queueItems startIndex:(NSUInteger)startIndex playPosition:(NSTimeInterval)playPosition repeatMode:(GCKMediaRepeatMode)repeatMode customData:(id _Nullable)customData;
		[Export("queueLoadItems:startIndex:playPosition:repeatMode:customData:")]
		GCKRequest QueueLoadItems(GCKMediaQueueItem[] queueItems, nuint startIndex, double playPosition, GCKMediaRepeatMode repeatMode, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)queueInsertItems:(NSArray<GCKMediaQueueItem *> * _Nonnull)queueItems beforeItemWithID:(NSUInteger)beforeItemID;
		[Export("queueInsertItems:beforeItemWithID:")]
		GCKRequest QueueInsertItems(GCKMediaQueueItem[] queueItems, nuint beforeItemID);

		// -(GCKRequest * _Nonnull)queueInsertItems:(NSArray<GCKMediaQueueItem *> * _Nonnull)queueItems beforeItemWithID:(NSUInteger)beforeItemID customData:(id _Nullable)customData;
		[Export("queueInsertItems:beforeItemWithID:customData:")]
		GCKRequest QueueInsertItems(GCKMediaQueueItem[] queueItems, nuint beforeItemID, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)queueInsertItem:(GCKMediaQueueItem * _Nonnull)item beforeItemWithID:(NSUInteger)beforeItemID;
		[Export("queueInsertItem:beforeItemWithID:")]
		GCKRequest QueueInsertItem(GCKMediaQueueItem item, nuint beforeItemID);

		// -(GCKRequest * _Nonnull)queueInsertAndPlayItem:(GCKMediaQueueItem * _Nonnull)item beforeItemWithID:(NSUInteger)beforeItemID;
		[Export("queueInsertAndPlayItem:beforeItemWithID:")]
		GCKRequest QueueInsertAndPlayItem(GCKMediaQueueItem item, nuint beforeItemID);

		// -(GCKRequest * _Nonnull)queueInsertAndPlayItem:(GCKMediaQueueItem * _Nonnull)item beforeItemWithID:(NSUInteger)beforeItemID playPosition:(NSTimeInterval)playPosition customData:(id _Nullable)customData;
		[Export("queueInsertAndPlayItem:beforeItemWithID:playPosition:customData:")]
		GCKRequest QueueInsertAndPlayItem(GCKMediaQueueItem item, nuint beforeItemID, double playPosition, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)queueUpdateItems:(NSArray<GCKMediaQueueItem *> * _Nonnull)queueItems;
		[Export("queueUpdateItems:")]
		GCKRequest QueueUpdateItems(GCKMediaQueueItem[] queueItems);

		// -(GCKRequest * _Nonnull)queueUpdateItems:(NSArray<GCKMediaQueueItem *> * _Nonnull)queueItems customData:(id _Nullable)customData;
		[Export("queueUpdateItems:customData:")]
		GCKRequest QueueUpdateItems(GCKMediaQueueItem[] queueItems, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)queueRemoveItemsWithIDs:(NSArray<NSNumber *> * _Nonnull)itemIDs;
		[Export("queueRemoveItemsWithIDs:")]
		GCKRequest QueueRemoveItemsWithIDs(NSNumber[] itemIDs);

		// -(GCKRequest * _Nonnull)queueRemoveItemsWithIDs:(NSArray<NSNumber *> * _Nonnull)itemIDs customData:(id _Nullable)customData;
		[Export("queueRemoveItemsWithIDs:customData:")]
		GCKRequest QueueRemoveItemsWithIDs(NSNumber[] itemIDs, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)queueRemoveItemWithID:(NSUInteger)itemID;
		[Export("queueRemoveItemWithID:")]
		GCKRequest QueueRemoveItemWithID(nuint itemID);

		// -(GCKRequest * _Nonnull)queueReorderItemsWithIDs:(NSArray<NSNumber *> * _Nonnull)queueItemIDs insertBeforeItemWithID:(NSUInteger)beforeItemID;
		[Export("queueReorderItemsWithIDs:insertBeforeItemWithID:")]
		GCKRequest QueueReorderItemsWithIDs(NSNumber[] queueItemIDs, nuint beforeItemID);

		// -(GCKRequest * _Nonnull)queueReorderItemsWithIDs:(NSArray<NSNumber *> * _Nonnull)queueItemIDs insertBeforeItemWithID:(NSUInteger)beforeItemID customData:(id _Nullable)customData;
		[Export("queueReorderItemsWithIDs:insertBeforeItemWithID:customData:")]
		GCKRequest QueueReorderItemsWithIDs(NSNumber[] queueItemIDs, nuint beforeItemID, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)queueMoveItemWithID:(NSUInteger)itemID beforeItemWithID:(NSUInteger)beforeItemID;
		[Export("queueMoveItemWithID:beforeItemWithID:")]
		GCKRequest QueueMoveItemWithID(nuint itemID, nuint beforeItemID);

		// -(GCKRequest * _Nonnull)queueJumpToItemWithID:(NSUInteger)itemID;
		[Export("queueJumpToItemWithID:")]
		GCKRequest QueueJumpToItemWithID(nuint itemID);

		// -(GCKRequest * _Nonnull)queueJumpToItemWithID:(NSUInteger)itemID customData:(id _Nullable)customData;
		[Export("queueJumpToItemWithID:customData:")]
		GCKRequest QueueJumpToItemWithID(nuint itemID, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)queueJumpToItemWithID:(NSUInteger)itemID playPosition:(NSTimeInterval)playPosition customData:(id _Nullable)customData;
		[Export("queueJumpToItemWithID:playPosition:customData:")]
		GCKRequest QueueJumpToItemWithID(nuint itemID, double playPosition, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)queueNextItem;
		[Export("queueNextItem")]
		GCKRequest QueueNextItem();

		// -(GCKRequest * _Nonnull)queuePreviousItem;
		[Export("queuePreviousItem")]
		GCKRequest QueuePreviousItem();

		// -(GCKRequest * _Nonnull)queueSetRepeatMode:(GCKMediaRepeatMode)repeatMode;
		[Export("queueSetRepeatMode:")]
		GCKRequest QueueSetRepeatMode(GCKMediaRepeatMode repeatMode);

		// -(GCKRequest * _Nonnull)setStreamVolume:(float)volume;
		[Export("setStreamVolume:")]
		GCKRequest SetStreamVolume(float volume);

		// -(GCKRequest * _Nonnull)setStreamVolume:(float)volume customData:(id _Nullable)customData;
		[Export("setStreamVolume:customData:")]
		GCKRequest SetStreamVolume(float volume, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)setStreamMuted:(BOOL)muted;
		[Export("setStreamMuted:")]
		GCKRequest SetStreamMuted(bool muted);

		// -(GCKRequest * _Nonnull)setStreamMuted:(BOOL)muted customData:(id _Nullable)customData;
		[Export("setStreamMuted:customData:")]
		GCKRequest SetStreamMuted(bool muted, [NullAllowed] NSObject customData);

		// -(GCKRequest * _Nonnull)requestStatus;
		[Export("requestStatus")]
		GCKRequest RequestStatus();

		// -(NSTimeInterval)approximateStreamPosition;
		[Export("approximateStreamPosition")]
		double ApproximateStreamPosition();
	}

	// @protocol GCKRemoteMediaClientListener <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKRemoteMediaClientListener
	{
		// @optional -(void)remoteMediaClient:(GCKRemoteMediaClient * _Nonnull)client didStartMediaSessionWithID:(NSInteger)sessionID;
		[Export("remoteMediaClient:didStartMediaSessionWithID:")]
		void RemoteMediaClientDidStartMediaSessionWithID(GCKRemoteMediaClient client, nint sessionID);

		// @optional -(void)remoteMediaClient:(GCKRemoteMediaClient * _Nonnull)client didUpdateMediaStatus:(GCKMediaStatus * _Nonnull)mediaStatus;
		[Export("remoteMediaClient:didUpdateMediaStatus:")]
		void RemoteMediaClientDidUpdateMediaStatus(GCKRemoteMediaClient client, GCKMediaStatus mediaStatus);

		// @optional -(void)remoteMediaClient:(GCKRemoteMediaClient * _Nonnull)client didUpdateMediaMetadata:(GCKMediaMetadata * _Nonnull)mediaMetadata;
		[Export("remoteMediaClient:didUpdateMediaMetadata:")]
		void RemoteMediaClientDidUpdateMediaMetadata(GCKRemoteMediaClient client, GCKMediaMetadata mediaMetadata);

		// @optional -(void)remoteMediaClientDidUpdateQueue:(GCKRemoteMediaClient * _Nonnull)client;
		[Export("remoteMediaClientDidUpdateQueue:")]
		void RemoteMediaClientDidUpdateQueue(GCKRemoteMediaClient client);

		// @optional -(void)remoteMediaClientDidUpdatePreloadStatus:(GCKRemoteMediaClient * _Nonnull)client;
		[Export("remoteMediaClientDidUpdatePreloadStatus:")]
		void RemoteMediaClientDidUpdatePreloadStatus(GCKRemoteMediaClient client);
	}

	// @protocol GCKRemoteMediaClientAdInfoParserDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKRemoteMediaClientAdInfoParserDelegate
	{
		// @optional -(BOOL)remoteMediaClient:(GCKRemoteMediaClient * _Nonnull)client shouldSetPlayingAdInMediaStatus:(GCKMediaStatus * _Nonnull)mediaStatus;
		[Export("remoteMediaClient:shouldSetPlayingAdInMediaStatus:")]
		bool RemoteMediaClientShouldSetPlayingAdInMediaStatus(GCKRemoteMediaClient client, GCKMediaStatus mediaStatus);

		// @optional -(NSArray<GCKAdBreakInfo *> * _Nullable)remoteMediaClient:(GCKRemoteMediaClient * _Nonnull)client shouldSetAdBreaksInMediaStatus:(GCKMediaStatus * _Nonnull)mediaStatus;
		[Export("remoteMediaClient:shouldSetAdBreaksInMediaStatus:")]
		[return: NullAllowed]
		GCKAdBreakInfo[] RemoteMediaClientShouldSetAdBreaksInMediaStatus(GCKRemoteMediaClient client, GCKMediaStatus mediaStatus);
	}

	// @interface GCKRequest : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKRequest
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		GCKRequestDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<GCKRequestDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, assign, nonatomic) GCKRequestID requestID;
		[Export("requestID")]
		nint RequestID { get; }

		// @property (readonly, copy, nonatomic) GCKError * _Nullable error;
		[NullAllowed, Export("error", ArgumentSemantic.Copy)]
		GCKError Error { get; }

		// @property (readonly, assign, nonatomic) BOOL inProgress;
		[Export("inProgress")]
		bool InProgress { get; }

		// -(void)cancel;
		[Export("cancel")]
		void Cancel();
	}

	// @protocol GCKRequestDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKRequestDelegate
	{
		// @optional -(void)requestDidComplete:(GCKRequest * _Nonnull)request;
		[Export("requestDidComplete:")]
		void RequestDidComplete(GCKRequest request);

		// @optional -(void)request:(GCKRequest * _Nonnull)request didFailWithError:(GCKError * _Nonnull)error;
		[Export("request:didFailWithError:")]
		void Request(GCKRequest request, GCKError error);

		// @optional -(void)request:(GCKRequest * _Nonnull)request didAbortWithReason:(GCKRequestAbortReason)abortReason;
		[Export("request:didAbortWithReason:")]
		void Request(GCKRequest request, GCKRequestAbortReason abortReason);
	}

	// @interface GCKSenderApplicationInfo : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GCKSenderApplicationInfo : INSCopying
	{
		// @property (readonly, assign, nonatomic) GCKSenderApplicationInfoPlatform platform;
		[Export("platform", ArgumentSemantic.Assign)]
		GCKSenderApplicationInfoPlatform Platform { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable appIdentifier;
		[NullAllowed, Export("appIdentifier")]
		string AppIdentifier { get; }

		// @property (readonly, nonatomic, strong) NSURL * _Nullable launchURL;
		[NullAllowed, Export("launchURL", ArgumentSemantic.Strong)]
		NSUrl LaunchURL { get; }
	}

	// @interface Protected
	interface Protected
	{
		// -(void)start;
		[Export("start")]
		void Start();

		// -(void)endAndStopCasting:(BOOL)stopCasting;
		[Export("endAndStopCasting:")]
		void EndAndStopCasting(bool stopCasting);

		// -(void)suspendWithReason:(GCKConnectionSuspendReason)reason;
		[Export("suspendWithReason:")]
		void SuspendWithReason(GCKConnectionSuspendReason reason);

		// -(void)resume;
		[Export("resume")]
		void Resume();

		// -(void)notifyDidStartWithSessionID:(NSString * _Nonnull)sessionID;
		[Export("notifyDidStartWithSessionID:")]
		void NotifyDidStartWithSessionID(string sessionID);

		// -(void)notifyDidFailToStartWithError:(NSError * _Nonnull)error;
		[Export("notifyDidFailToStartWithError:")]
		void NotifyDidFailToStartWithError(NSError error);

		// -(void)notifyDidResume;
		[Export("notifyDidResume")]
		void NotifyDidResume();

		// -(void)notifyDidSuspendWithReason:(GCKConnectionSuspendReason)reason;
		[Export("notifyDidSuspendWithReason:")]
		void NotifyDidSuspendWithReason(GCKConnectionSuspendReason reason);

		// -(void)notifyDidEndWithError:(NSError * _Nullable)error;
		[Export("notifyDidEndWithError:")]
		void NotifyDidEndWithError([NullAllowed] NSError error);

		// -(void)notifyDidReceiveDeviceVolume:(float)volume muted:(BOOL)muted;
		[Export("notifyDidReceiveDeviceVolume:muted:")]
		void NotifyDidReceiveDeviceVolume(float volume, bool muted);

		// -(void)notifyDidReceiveDeviceStatus:(NSString * _Nullable)statusText;
		[Export("notifyDidReceiveDeviceStatus:")]
		void NotifyDidReceiveDeviceStatus([NullAllowed] string statusText);
	}

	// @interface GCKSession : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKSession
	{
		// @property (readonly, nonatomic, strong) GCKDevice * _Nonnull device;
		[Export("device", ArgumentSemantic.Strong)]
		GCKDevice Device { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sessionID;
		[NullAllowed, Export("sessionID")]
		string SessionID { get; }

		// @property (readonly, assign, nonatomic) GCKConnectionState connectionState;
		[Export("connectionState", ArgumentSemantic.Assign)]
		GCKConnectionState ConnectionState { get; }

		// @property (readonly, assign, nonatomic) BOOL suspended;
		[Export("suspended")]
		bool Suspended { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable deviceStatusText;
		[NullAllowed, Export("deviceStatusText")]
		string DeviceStatusText { get; }

		// @property (readonly, copy, nonatomic) int * _Nonnull traits;
		[Export("traits", ArgumentSemantic.Copy)]
		GCKSessionTraits Traits { get; }

		// @property (readonly, assign, nonatomic) float currentDeviceVolume;
		[Export("currentDeviceVolume")]
		float CurrentDeviceVolume { get; }

		// @property (readonly, assign, nonatomic) BOOL currentDeviceMuted;
		[Export("currentDeviceMuted")]
		bool CurrentDeviceMuted { get; }

		// @property (readonly, nonatomic, strong) GCKRemoteMediaClient * _Nullable remoteMediaClient;
		[NullAllowed, Export("remoteMediaClient", ArgumentSemantic.Strong)]
		GCKRemoteMediaClient RemoteMediaClient { get; }

		// @property (readonly, nonatomic, strong) GCKMediaMetadata * _Nullable mediaMetadata;
		[NullAllowed, Export("mediaMetadata", ArgumentSemantic.Strong)]
		GCKMediaMetadata MediaMetadata { get; }

		// -(instancetype _Nonnull)initWithDevice:(GCKDevice * _Nonnull)device traits:(id)traits sessionID:(NSString * _Nullable)sessionID;
		[Export("initWithDevice:traits:sessionID:")]
		IntPtr Constructor(GCKDevice device, NSObject traits, [NullAllowed] string sessionID);

		// -(void)setDeviceVolume:(float)volume;
		[Export("setDeviceVolume:")]
		void SetDeviceVolume(float volume);

		// -(void)setDeviceMuted:(BOOL)muted;
		[Export("setDeviceMuted:")]
		void SetDeviceMuted(bool muted);
	}

	partial interface Constants
	{
		// extern NSString *const _Nonnull kGCKKeyConnectionState __attribute__((visibility("default")));
		[Field("kGCKKeyConnectionState", "__Internal")]
		NSString kGCKKeyConnectionState { get; }
	}

	// @interface GCKSessionManager : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKSessionManager
	{
		// @property (readonly, nonatomic, strong) GCKSession * _Nullable currentSession;
		[NullAllowed, Export("currentSession", ArgumentSemantic.Strong)]
		GCKSession CurrentSession { get; }

		// @property (readonly, nonatomic, strong) GCKCastSession * _Nullable currentCastSession;
		[NullAllowed, Export("currentCastSession", ArgumentSemantic.Strong)]
		GCKCastSession CurrentCastSession { get; }

		// @property (readonly, assign, nonatomic) GCKConnectionState connectionState;
		[Export("connectionState", ArgumentSemantic.Assign)]
		GCKConnectionState ConnectionState { get; }

		// -(BOOL)startSessionWithDevice:(GCKDevice * _Nonnull)device;
		[Export("startSessionWithDevice:")]
		bool StartSessionWithDevice(GCKDevice device);

		// -(BOOL)suspendSessionWithReason:(GCKConnectionSuspendReason)reason;
		[Export("suspendSessionWithReason:")]
		bool SuspendSessionWithReason(GCKConnectionSuspendReason reason);

		// -(BOOL)endSession;
		[Export("endSession")]
		bool EndSession();

		// -(BOOL)endSessionAndStopCasting:(BOOL)stopCasting;
		[Export("endSessionAndStopCasting:")]
		bool EndSessionAndStopCasting(bool stopCasting);

		// -(BOOL)hasConnectedSession;
		[Export("hasConnectedSession")]
		bool HasConnectedSession();

		// -(BOOL)hasConnectedCastSession;
		[Export("hasConnectedCastSession")]
		bool HasConnectedCastSession();

		// -(void)addListener:(id<GCKSessionManagerListener> _Nonnull)listener;
		[Export("addListener:")]
		void AddListener(GCKSessionManagerListener listener);

		// -(void)removeListener:(id<GCKSessionManagerListener> _Nonnull)listener;
		[Export("removeListener:")]
		void RemoveListener(GCKSessionManagerListener listener);
	}

	// @protocol GCKSessionManagerListener <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKSessionManagerListener
	{
		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager willStartSession:(GCKSession * _Nonnull)session;
		[Export("sessionManager:willStartSession:")]
		void WillStartSession(GCKSessionManager sessionManager, GCKSession session);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager didStartSession:(GCKSession * _Nonnull)session;
		[Export("sessionManager:didStartSession:")]
		void DidStartSession(GCKSessionManager sessionManager, GCKSession session);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager willStartCastSession:(GCKCastSession * _Nonnull)session;
		[Export("sessionManager:willStartCastSession:")]
		void WillStartCastSession(GCKSessionManager sessionManager, GCKCastSession session);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager didStartCastSession:(GCKCastSession * _Nonnull)session;
		[Export("sessionManager:didStartCastSession:")]
		void DidStartCastSession(GCKSessionManager sessionManager, GCKCastSession session);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager willEndSession:(GCKSession * _Nonnull)session;
		[Export("sessionManager:willEndSession:")]
		void WillEndSession(GCKSessionManager sessionManager, GCKSession session);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager didEndSession:(GCKSession * _Nonnull)session withError:(NSError * _Nullable)error;
		[Export("sessionManager:didEndSession:withError:")]
		void DidEndSession(GCKSessionManager sessionManager, GCKSession session, [NullAllowed] NSError error);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager willEndCastSession:(GCKCastSession * _Nonnull)session;
		[Export("sessionManager:willEndCastSession:")]
		void WillEndCastSession(GCKSessionManager sessionManager, GCKCastSession session);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager didEndCastSession:(GCKCastSession * _Nonnull)session withError:(NSError * _Nullable)error;
		[Export("sessionManager:didEndCastSession:withError:")]
		void DidEndCastSession(GCKSessionManager sessionManager, GCKCastSession session, [NullAllowed] NSError error);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager didFailToStartSession:(GCKSession * _Nonnull)session withError:(NSError * _Nonnull)error;
		[Export("sessionManager:didFailToStartSession:withError:")]
		void DidFailToStartSession(GCKSessionManager sessionManager, GCKSession session, NSError error);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager didFailToStartCastSession:(GCKCastSession * _Nonnull)session withError:(NSError * _Nonnull)error;
		[Export("sessionManager:didFailToStartCastSession:withError:")]
		void DidFailToStartCastSession(GCKSessionManager sessionManager, GCKCastSession session, NSError error);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager didSuspendSession:(GCKSession * _Nonnull)session withReason:(GCKConnectionSuspendReason)reason;
		[Export("sessionManager:didSuspendSession:withReason:")]
		void DidSuspendSession(GCKSessionManager sessionManager, GCKSession session, GCKConnectionSuspendReason reason);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager didSuspendCastSession:(GCKCastSession * _Nonnull)session withReason:(GCKConnectionSuspendReason)reason;
		[Export("sessionManager:didSuspendCastSession:withReason:")]
		void DidSuspendCastSession(GCKSessionManager sessionManager, GCKCastSession session, GCKConnectionSuspendReason reason);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager willResumeSession:(GCKSession * _Nonnull)session;
		[Export("sessionManager:willResumeSession:")]
		void WillResumeSession(GCKSessionManager sessionManager, GCKSession session);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager didResumeSession:(GCKSession * _Nonnull)session;
		[Export("sessionManager:didResumeSession:")]
		void DidResumeSession(GCKSessionManager sessionManager, GCKSession session);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager willResumeCastSession:(GCKCastSession * _Nonnull)session;
		[Export("sessionManager:willResumeCastSession:")]
		void WillResumeCastSession(GCKSessionManager sessionManager, GCKCastSession session);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager didResumeCastSession:(GCKCastSession * _Nonnull)session;
		[Export("sessionManager:didResumeCastSession:")]
		void DidResumeCastSession(GCKSessionManager sessionManager, GCKCastSession session);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager session:(GCKSession * _Nonnull)session didUpdateDevice:(GCKDevice * _Nonnull)device;
		[Export("sessionManager:session:didUpdateDevice:")]
		void Session(GCKSessionManager sessionManager, GCKSession session, GCKDevice device);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager session:(GCKSession * _Nonnull)session didReceiveDeviceVolume:(float)volume muted:(BOOL)muted;
		[Export("sessionManager:session:didReceiveDeviceVolume:muted:")]
		void Session(GCKSessionManager sessionManager, GCKSession session, float volume, bool muted);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager castSession:(GCKCastSession * _Nonnull)session didReceiveDeviceVolume:(float)volume muted:(BOOL)muted;
		[Export("sessionManager:castSession:didReceiveDeviceVolume:muted:")]
		void CastSession(GCKSessionManager sessionManager, GCKCastSession session, float volume, bool muted);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager session:(GCKSession * _Nonnull)session didReceiveDeviceStatus:(NSString * _Nullable)statusText;
		[Export("sessionManager:session:didReceiveDeviceStatus:")]
		void Session(GCKSessionManager sessionManager, GCKSession session, [NullAllowed] string statusText);

		// @optional -(void)sessionManager:(GCKSessionManager * _Nonnull)sessionManager castSession:(GCKCastSession * _Nonnull)session didReceiveDeviceStatus:(NSString * _Nullable)statusText;
		[Export("sessionManager:castSession:didReceiveDeviceStatus:")]
		void CastSession(GCKSessionManager sessionManager, GCKCastSession session, [NullAllowed] string statusText);
	}

	// @interface GCKSessionTraits : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface GCKSessionTraits : INSCopying, INSCoding
	{
		// @property (readonly, assign, nonatomic) float minimumVolume;
		[Export("minimumVolume")]
		float MinimumVolume { get; }

		// @property (readonly, assign, nonatomic) float maximumVolume;
		[Export("maximumVolume")]
		float MaximumVolume { get; }

		// @property (readonly, assign, nonatomic) float volumeIncrement;
		[Export("volumeIncrement")]
		float VolumeIncrement { get; }

		// @property (readonly, assign, nonatomic) BOOL supportsMuting;
		[Export("supportsMuting")]
		bool SupportsMuting { get; }

		// -(instancetype _Nonnull)initWithMinimumVolume:(float)minimumVolume maximumVolume:(float)maximumVolume volumeIncrement:(float)volumeIncrement supportsMuting:(BOOL)supportsMuting __attribute__((objc_designated_initializer));
		[Export("initWithMinimumVolume:maximumVolume:volumeIncrement:supportsMuting:")]
		[DesignatedInitializer]
		IntPtr Constructor(float minimumVolume, float maximumVolume, float volumeIncrement, bool supportsMuting);

		// -(BOOL)isFixedVolume;
		[Export("isFixedVolume")]
		bool IsFixedVolume { get; }
	}

	// @interface GCKUIButton : UIButton
	[BaseType(typeof(UIButton))]
	interface GCKUIButton
	{
		// @property (assign, readwrite, nonatomic) UIControlState applicationState;
		[Export("applicationState", ArgumentSemantic.Assign)]
		UIControlState ApplicationState { get; set; }
	}

	// @interface GCKUICastButton : UIButton
	[BaseType(typeof(UIButton))]
	interface GCKUICastButton
	{
		// @property (assign, readwrite, nonatomic) BOOL triggersDefaultCastDialog;
		[Export("triggersDefaultCastDialog")]
		bool TriggersDefaultCastDialog { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame;
		[Export("initWithFrame:")]
		IntPtr Constructor(CGRect frame);

		// -(void)setInactiveIcon:(UIImage * _Nonnull)inactiveIcon activeIcon:(UIImage * _Nonnull)activeIcon animationIcons:(NSArray<UIImage *> * _Nonnull)animationIcons;
		[Export("setInactiveIcon:activeIcon:animationIcons:")]
		void SetInactiveIcon(UIImage inactiveIcon, UIImage activeIcon, UIImage[] animationIcons);
	}

	// @interface GCKUICastContainerViewController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface GCKUICastContainerViewController
	{
		// @property (readonly, nonatomic, strong) UIViewController * _Nullable contentViewController;
		[NullAllowed, Export("contentViewController", ArgumentSemantic.Strong)]
		UIViewController ContentViewController { get; }

		// @property (readonly, nonatomic, strong) GCKUIMiniMediaControlsViewController * _Nullable miniMediaControlsViewController;
		[NullAllowed, Export("miniMediaControlsViewController", ArgumentSemantic.Strong)]
		GCKUIMiniMediaControlsViewController MiniMediaControlsViewController { get; }

		// @property (assign, readwrite, nonatomic) BOOL miniMediaControlsItemEnabled;
		[Export("miniMediaControlsItemEnabled")]
		bool MiniMediaControlsItemEnabled { get; set; }
	}

	partial interface Constants
	{
		// extern const UIControlState GCKUIControlStateMuteOff __attribute__((visibility("default")));
		[Field("GCKUIControlStateMuteOff", "__Internal")]
		nint GCKUIControlStateMuteOff { get; }

		// extern const UIControlState GCKUIControlStateMuteOn __attribute__((visibility("default")));
		[Field("GCKUIControlStateMuteOn", "__Internal")]
		nint GCKUIControlStateMuteOn { get; }
	}

	// @interface GCKUIDeviceVolumeController : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKUIDeviceVolumeController
	{
		// @property (readwrite, nonatomic, weak) UIButton * _Nullable volumeUpButton;
		[NullAllowed, Export("volumeUpButton", ArgumentSemantic.Weak)]
		UIButton VolumeUpButton { get; set; }

		// @property (readwrite, nonatomic, weak) UIButton * _Nullable volumeDownButton;
		[NullAllowed, Export("volumeDownButton", ArgumentSemantic.Weak)]
		UIButton VolumeDownButton { get; set; }

		// @property (readwrite, nonatomic, weak) UISlider * _Nullable volumeSlider;
		[NullAllowed, Export("volumeSlider", ArgumentSemantic.Weak)]
		UISlider VolumeSlider { get; set; }

		// @property (readwrite, nonatomic, weak) UISwitch * _Nullable muteSwitch;
		[NullAllowed, Export("muteSwitch", ArgumentSemantic.Weak)]
		UISwitch MuteSwitch { get; set; }

		// @property (readwrite, nonatomic, weak) GCKUIButton * _Nullable muteToggleButton;
		[NullAllowed, Export("muteToggleButton", ArgumentSemantic.Weak)]
		GCKUIButton MuteToggleButton { get; set; }

		// -(void)setVolume:(float)volume;
		[Export("setVolume:")]
		void SetVolume(float volume);

		// -(void)setMuted:(BOOL)muted;
		[Export("setMuted:")]
		void SetMuted(bool muted);

		// -(void)volumeUp;
		[Export("volumeUp")]
		void VolumeUp();

		// -(void)volumeDown;
		[Export("volumeDown")]
		void VolumeDown();

		// -(void)toggleMuted;
		[Export("toggleMuted")]
		void ToggleMuted();
	}

	// @interface GCKUIExpandedMediaControlsViewController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface GCKUIExpandedMediaControlsViewController
	{
	}

	// @protocol GCKUIImageCache <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKUIImageCache
	{
		// @required -(void)fetchImageForURL:(NSURL * _Nonnull)imageURL completion:(void (^ _Nonnull)(UIImage * _Nullable))completion;
		[Abstract]
		[Export("fetchImageForURL:completion:")]
		void Completion(NSUrl imageURL, Action<UIImage> completion);
	}

	// @interface GCKUIImageHints : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface GCKUIImageHints : INSCopying, INSCoding
	{
		// @property (readonly, assign, nonatomic) GCKMediaMetadataImageType imageType;
		[Export("imageType", ArgumentSemantic.Assign)]
		GCKMediaMetadataImageType ImageType { get; }

		// @property (readonly, assign, nonatomic) CGSize imageSize;
		[Export("imageSize", ArgumentSemantic.Assign)]
		CGSize ImageSize { get; }

		// @property (readonly, copy, nonatomic) NSObject<NSCoding> * _Nullable customData;
		[NullAllowed, Export("customData", ArgumentSemantic.Copy)]
		NSCoding CustomData { get; }

		// -(instancetype _Nonnull)initWithImageType:(GCKMediaMetadataImageType)imageType imageSize:(CGSize)imageSize;
		[Export("initWithImageType:imageSize:")]
		IntPtr Constructor(GCKMediaMetadataImageType imageType, CGSize imageSize);

		// -(instancetype _Nonnull)initWithImageType:(GCKMediaMetadataImageType)imageType imageSize:(CGSize)imageSize customData:(NSObject<NSCoding> * _Nullable)customData;
		[Export("initWithImageType:imageSize:customData:")]
		IntPtr Constructor(GCKMediaMetadataImageType imageType, CGSize imageSize, [NullAllowed] NSCoding customData);
	}

	// @protocol GCKUIImagePicker <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKUIImagePicker
	{
		// @required -(GCKImage * _Nullable)getImageWithHints:(GCKUIImageHints * _Nonnull)imageHints fromMetadata:(const GCKMediaMetadata * _Nonnull)metadata;
		[Abstract]
		[Export("getImageWithHints:fromMetadata:")]
		[return: NullAllowed]
		GCKImage FromMetadata(GCKUIImageHints imageHints, GCKMediaMetadata metadata);
	}

	// @protocol GCKUIMediaButtonBarProtocol <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface IGCKUIMediaButtonBarProtocol
	{
		// @required -(NSUInteger)buttonCount;
		[Abstract]
		[Export("buttonCount")]
		nuint ButtonCount { get; }

		// @required -(void)setButtonType:(GCKUIMediaButtonType)buttonType atIndex:(NSUInteger)index;
		[Abstract]
		[Export("setButtonType:atIndex:")]
		void SetButtonType(GCKUIMediaButtonType buttonType, nuint index);

		// @required -(GCKUIMediaButtonType)buttonTypeAtIndex:(NSUInteger)index;
		[Abstract]
		[Export("buttonTypeAtIndex:")]
		GCKUIMediaButtonType ButtonTypeAtIndex(nuint index);

		// @required -(void)setCustomButton:(UIButton * _Nullable)customButton atIndex:(NSUInteger)index;
		[Abstract]
		[Export("setCustomButton:atIndex:")]
		void SetCustomButton([NullAllowed] UIButton customButton, nuint index);

		// @required -(UIButton * _Nullable)customButtonAtIndex:(NSUInteger)index;
		[Abstract]
		[Export("customButtonAtIndex:")]
		[return: NullAllowed]
		UIButton CustomButtonAtIndex(nuint index);
	}

	partial interface Constants
	{
		// extern const UIControlState GCKUIControlStateRepeatOff __attribute__((visibility("default")));
		[Field("GCKUIControlStateRepeatOff", "__Internal")]
		nint GCKUIControlStateRepeatOff { get; }

		// extern const UIControlState GCKUIControlStateRepeatAll __attribute__((visibility("default")));
		[Field("GCKUIControlStateRepeatAll", "__Internal")]
		nint GCKUIControlStateRepeatAll { get; }

		// extern const UIControlState GCKUIControlStateRepeatSingle __attribute__((visibility("default")));
		[Field("GCKUIControlStateRepeatSingle", "__Internal")]
		nint GCKUIControlStateRepeatSingle { get; }

		// extern const UIControlState GCKUIControlStatePlay __attribute__((visibility("default")));
		[Field("GCKUIControlStatePlay", "__Internal")]
		nint GCKUIControlStatePlay { get; }

		// extern const UIControlState GCKUIControlStatePause __attribute__((visibility("default")));
		[Field("GCKUIControlStatePause", "__Internal")]
		nint GCKUIControlStatePause { get; }

		// extern const UIControlState GCKUIControlStateShuffle __attribute__((visibility("default")));
		[Field("GCKUIControlStateShuffle", "__Internal")]
		nint GCKUIControlStateShuffle { get; }
	}

	// typedef NSString * _Nonnull (^GCKUIValueFormatter)(const id _Nonnull);
	delegate string GCKUIValueFormatter(NSObject arg0);

	// @interface GCKUIMediaController : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKUIMediaController
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		GCKUIMediaControllerDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<GCKUIMediaControllerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) GCKSession * _Nullable session;
		[NullAllowed, Export("session", ArgumentSemantic.Strong)]
		GCKSession Session { get; }

		// @property (readonly, assign, nonatomic) BOOL mediaLoaded;
		[Export("mediaLoaded")]
		bool MediaLoaded { get; }

		// @property (readonly, assign, nonatomic) BOOL hasCurrentQueueItem;
		[Export("hasCurrentQueueItem")]
		bool HasCurrentQueueItem { get; }

		// @property (readonly, assign, nonatomic) BOOL hasLoadingQueueItem;
		[Export("hasLoadingQueueItem")]
		bool HasLoadingQueueItem { get; }

		// @property (readonly, assign, nonatomic) GCKMediaPlayerState lastKnownPlayerState;
		[Export("lastKnownPlayerState", ArgumentSemantic.Assign)]
		GCKMediaPlayerState LastKnownPlayerState { get; }

		// @property (readonly, assign, nonatomic) NSTimeInterval lastKnownStreamPosition;
		[Export("lastKnownStreamPosition")]
		double LastKnownStreamPosition { get; }

		// @property (readwrite, nonatomic, weak) UIButton * _Nullable playButton;
		[NullAllowed, Export("playButton", ArgumentSemantic.Weak)]
		UIButton PlayButton { get; set; }

		// @property (readwrite, nonatomic, weak) UIButton * _Nullable pauseButton;
		[NullAllowed, Export("pauseButton", ArgumentSemantic.Weak)]
		UIButton PauseButton { get; set; }

		// @property (readwrite, nonatomic, weak) GCKUIButton * _Nullable playPauseToggleButton;
		[NullAllowed, Export("playPauseToggleButton", ArgumentSemantic.Weak)]
		GCKUIButton PlayPauseToggleButton { get; set; }

		// @property (readwrite, nonatomic, weak) UIButton * _Nullable stopButton;
		[NullAllowed, Export("stopButton", ArgumentSemantic.Weak)]
		UIButton StopButton { get; set; }

		// @property (readwrite, nonatomic, weak) GCKUIButton * _Nullable forward30SecondsButton;
		[NullAllowed, Export("forward30SecondsButton", ArgumentSemantic.Weak)]
		GCKUIButton Forward30SecondsButton { get; set; }

		// @property (readwrite, nonatomic, weak) GCKUIButton * _Nullable rewind30SecondsButton;
		[NullAllowed, Export("rewind30SecondsButton", ArgumentSemantic.Weak)]
		GCKUIButton Rewind30SecondsButton { get; set; }

		// @property (readwrite, nonatomic, weak) UIButton * _Nullable pauseQueueButton;
		[NullAllowed, Export("pauseQueueButton", ArgumentSemantic.Weak)]
		UIButton PauseQueueButton { get; set; }

		// @property (readwrite, nonatomic, weak) UIButton * _Nullable nextButton;
		[NullAllowed, Export("nextButton", ArgumentSemantic.Weak)]
		UIButton NextButton { get; set; }

		// @property (readwrite, nonatomic, weak) UIButton * _Nullable previousButton;
		[NullAllowed, Export("previousButton", ArgumentSemantic.Weak)]
		UIButton PreviousButton { get; set; }

		// @property (readwrite, nonatomic, weak) GCKUIButton * _Nullable repeatModeButton;
		[NullAllowed, Export("repeatModeButton", ArgumentSemantic.Weak)]
		GCKUIButton RepeatModeButton { get; set; }

		// @property (readwrite, nonatomic, weak) UISlider * _Nullable streamPositionSlider;
		[NullAllowed, Export("streamPositionSlider", ArgumentSemantic.Weak)]
		UISlider StreamPositionSlider { get; set; }

		// @property (readwrite, nonatomic, weak) UIProgressView * _Nullable streamProgressView;
		[NullAllowed, Export("streamProgressView", ArgumentSemantic.Weak)]
		UIProgressView StreamProgressView { get; set; }

		// @property (readwrite, nonatomic, weak) UILabel * _Nullable streamPositionLabel;
		[NullAllowed, Export("streamPositionLabel", ArgumentSemantic.Weak)]
		UILabel StreamPositionLabel { get; set; }

		// @property (readwrite, nonatomic, weak) UILabel * _Nullable streamDurationLabel;
		[NullAllowed, Export("streamDurationLabel", ArgumentSemantic.Weak)]
		UILabel StreamDurationLabel { get; set; }

		// @property (readwrite, nonatomic, weak) UILabel * _Nullable streamTimeRemainingLabel;
		[NullAllowed, Export("streamTimeRemainingLabel", ArgumentSemantic.Weak)]
		UILabel StreamTimeRemainingLabel { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL displayTimeRemainingAsNegativeValue;
		[Export("displayTimeRemainingAsNegativeValue")]
		bool DisplayTimeRemainingAsNegativeValue { get; set; }

		// @property (readwrite, nonatomic, weak) UIButton * _Nullable tracksButton;
		[NullAllowed, Export("tracksButton", ArgumentSemantic.Weak)]
		UIButton TracksButton { get; set; }

		// @property (readwrite, nonatomic, weak) UILabel * _Nullable smartSubtitleLabel;
		[NullAllowed, Export("smartSubtitleLabel", ArgumentSemantic.Weak)]
		UILabel SmartSubtitleLabel { get; set; }

		// @property (readwrite, nonatomic, weak) UIActivityIndicatorView * _Nullable mediaLoadingIndicator;
		[NullAllowed, Export("mediaLoadingIndicator", ArgumentSemantic.Weak)]
		UIActivityIndicatorView MediaLoadingIndicator { get; set; }

		// -(void)bindLabel:(UILabel * _Nonnull)label toMetadataKey:(NSString * _Nonnull)key;
		[Export("bindLabel:toMetadataKey:")]
		void BindLabel(UILabel label, string key);

		// -(void)bindLabel:(UILabel * _Nonnull)label toMetadataKey:(NSString * _Nonnull)key withFormatter:(GCKUIValueFormatter _Nonnull)formatter;
		[Export("bindLabel:toMetadataKey:withFormatter:")]
		void BindLabel(UILabel label, string key, GCKUIValueFormatter formatter);

		// -(void)bindTextView:(UITextView * _Nonnull)textView toMetadataKey:(NSString * _Nonnull)key;
		[Export("bindTextView:toMetadataKey:")]
		void BindTextView(UITextView textView, string key);

		// -(void)bindTextView:(UITextView * _Nonnull)textView toMetadataKey:(NSString * _Nonnull)key withFormatter:(GCKUIValueFormatter _Nonnull)formatter;
		[Export("bindTextView:toMetadataKey:withFormatter:")]
		void BindTextView(UITextView textView, string key, GCKUIValueFormatter formatter);

		// -(void)bindImageView:(UIImageView * _Nonnull)imageView toImageHints:(GCKUIImageHints * _Nonnull)imageHints;
		[Export("bindImageView:toImageHints:")]
		void BindImageView(UIImageView imageView, GCKUIImageHints imageHints);

		// -(void)unbindView:(UIView * _Nonnull)view;
		[Export("unbindView:")]
		void UnbindView(UIView view);

		// -(void)unbindAllViews;
		[Export("unbindAllViews")]
		void UnbindAllViews();

		// -(GCKMediaRepeatMode)cycleRepeatMode;
		[Export("cycleRepeatMode")]
		GCKMediaRepeatMode CycleRepeatMode { get; }

		// -(void)selectTracks;
		[Export("selectTracks")]
		void SelectTracks();
	}

	// @protocol GCKUIMediaControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKUIMediaControllerDelegate
	{
		// @optional -(void)mediaController:(GCKUIMediaController * _Nonnull)mediaController didUpdatePlayerState:(GCKMediaPlayerState)playerState lastStreamPosition:(NSTimeInterval)streamPosition;
		[Export("mediaController:didUpdatePlayerState:lastStreamPosition:")]
		void DidUpdatePlayerState(GCKUIMediaController mediaController, GCKMediaPlayerState playerState, double streamPosition);

		// @optional -(void)mediaController:(GCKUIMediaController * _Nonnull)mediaController didBeginPreloadForItemID:(NSUInteger)itemID;
		[Export("mediaController:didBeginPreloadForItemID:")]
		void DidBeginPreloadForItemID(GCKUIMediaController mediaController, nuint itemID);

		// @optional -(void)mediaController:(GCKUIMediaController * _Nonnull)mediaController didUpdateMediaStatus:(GCKMediaStatus * _Nonnull)mediaStatus;
		[Export("mediaController:didUpdateMediaStatus:")]
		void DidUpdateMediaStatus(GCKUIMediaController mediaController, GCKMediaStatus mediaStatus);
	}

	// @interface GCKUIMediaTrackSelectionViewController : UITabBarController
	[BaseType(typeof(UITabBarController))]
	interface GCKUIMediaTrackSelectionViewController
	{
		[Wrap("WeakSelectionDelegate")]
		[NullAllowed]
		GCKUIMediaTrackSelectionViewControllerDelegate SelectionDelegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<GCKUIMediaTrackSelectionViewControllerDelegate> _Nullable selectionDelegate;
		[NullAllowed, Export("selectionDelegate", ArgumentSemantic.Weak)]
		NSObject WeakSelectionDelegate { get; set; }

		// @property (readwrite, nonatomic, strong) GCKMediaInformation * _Nullable mediaInfo;
		[NullAllowed, Export("mediaInfo", ArgumentSemantic.Strong)]
		GCKMediaInformation MediaInfo { get; set; }

		// @property (readwrite, copy, nonatomic) NSArray<NSNumber *> * _Nullable selectedTrackIDs;
		[NullAllowed, Export("selectedTrackIDs", ArgumentSemantic.Copy)]
		NSNumber[] SelectedTrackIDs { get; set; }
	}

	// @protocol GCKUIMediaTrackSelectionViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKUIMediaTrackSelectionViewControllerDelegate
	{
		// @required -(void)didSelectMediaTracks:(NSArray<NSNumber *> * _Nonnull)mediaTrackIDs;
		[Abstract]
		[Export("didSelectMediaTracks:")]
		void DidSelectMediaTracks(NSNumber[] mediaTrackIDs);
	}

	// @interface GCKUIMiniMediaControlsViewController : UIViewController <GCKUIMediaButtonBarProtocol>
	[BaseType(typeof(UIViewController))]
	interface GCKUIMiniMediaControlsViewController : IGCKUIMediaButtonBarProtocol
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		GCKUIMiniMediaControlsViewControllerDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<GCKUIMiniMediaControlsViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL thumbnailEnabled;
		[Export("thumbnailEnabled")]
		bool ThumbnailEnabled { get; set; }

		// @property (readonly, assign, nonatomic) BOOL active;
		[Export("active")]
		bool Active { get; }

		// @property (readonly, assign, nonatomic) CGFloat minHeight;
		[Export("minHeight")]
		nfloat MinHeight { get; }
	}

	// @protocol GCKUIMiniMediaControlsViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface GCKUIMiniMediaControlsViewControllerDelegate
	{
		// @required -(void)miniMediaControlsViewController:(GCKUIMiniMediaControlsViewController * _Nonnull)miniMediaControlsViewController shouldAppear:(BOOL)shouldAppear;
		[Abstract]
		[Export("miniMediaControlsViewController:shouldAppear:")]
		void ShouldAppear(GCKUIMiniMediaControlsViewController miniMediaControlsViewController, bool shouldAppear);
	}

	// @interface GCKUIUtils : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKUIUtils
	{
		// +(UIViewController * _Nullable)currentViewController;
		[Static]
		[NullAllowed, Export("currentViewController")]
		UIViewController CurrentViewController { get; }

		// +(NSString * _Nonnull)timeIntervalAsString:(NSTimeInterval)timeInterval;
		[Static]
		[Export("timeIntervalAsString:")]
		string TimeIntervalAsString(double timeInterval);
	}

	// @interface GCKAdditions (NSDictionary)
	[Category]
	[BaseType(typeof(NSDictionary))]
	interface NSDictionary_GCKAdditions
	{
		// -(NSString * _Nullable)gck_stringForKey:(NSString * _Nonnull)key withDefaultValue:(NSString * _Nullable)defaultValue;
		[Export("gck_stringForKey:withDefaultValue:")]
		[return: NullAllowed]
		string Gck_stringForKey(string key, [NullAllowed] string defaultValue);

		// -(NSString * _Nullable)gck_stringForKey:(NSString * _Nonnull)key;
		[Export("gck_stringForKey:")]
		[return: NullAllowed]
		string Gck_stringForKey(string key);

		// -(NSInteger)gck_integerForKey:(NSString * _Nonnull)key withDefaultValue:(NSInteger)defaultValue;
		[Export("gck_integerForKey:withDefaultValue:")]
		nint Gck_integerForKey(string key, nint defaultValue);

		// -(NSUInteger)gck_uintegerForKey:(NSString * _Nonnull)key withDefaultValue:(NSUInteger)defaultValue;
		[Export("gck_uintegerForKey:withDefaultValue:")]
		nuint Gck_uintegerForKey(string key, nuint defaultValue);

		// -(NSInteger)gck_integerForKey:(NSString * _Nonnull)key;
		[Export("gck_integerForKey:")]
		nint Gck_integerForKey(string key);

		// -(NSUInteger)gck_uintegerForKey:(NSString * _Nonnull)key;
		[Export("gck_uintegerForKey:")]
		nuint Gck_uintegerForKey(string key);

		// -(double)gck_doubleForKey:(NSString * _Nonnull)key withDefaultValue:(double)defaultValue;
		[Export("gck_doubleForKey:withDefaultValue:")]
		double Gck_doubleForKey(string key, double defaultValue);

		// -(double)gck_doubleForKey:(NSString * _Nonnull)key;
		[Export("gck_doubleForKey:")]
		double Gck_doubleForKey(string key);

		// -(BOOL)gck_boolForKey:(NSString * _Nonnull)key withDefaultValue:(BOOL)defaultValue;
		[Export("gck_boolForKey:withDefaultValue:")]
		bool Gck_boolForKey(string key, bool defaultValue);

		// -(BOOL)gck_boolForKey:(NSString * _Nonnull)key;
		[Export("gck_boolForKey:")]
		bool Gck_boolForKey(string key);

		// -(NSDictionary * _Nullable)gck_dictionaryForKey:(NSString * _Nonnull)key;
		[Export("gck_dictionaryForKey:")]
		[return: NullAllowed]
		NSDictionary Gck_dictionaryForKey(string key);

		// -(NSArray * _Nullable)gck_arrayForKey:(NSString * _Nonnull)key;
		[Export("gck_arrayForKey:")]
		[return: NullAllowed]
		NSObject[] Gck_arrayForKey(string key);

		// -(NSURL * _Nullable)gck_urlForKey:(NSString * _Nonnull)key;
		[Export("gck_urlForKey:")]
		[return: NullAllowed]
		NSUrl Gck_urlForKey(string key);

		// -(void)gck_setStringValue:(NSString * _Nonnull)value forKey:(NSString * _Nonnull)key;
		[Export("gck_setStringValue:forKey:")]
		void Gck_setStringValue(string value, string key);

		// -(void)gck_setIntegerValue:(NSInteger)value forKey:(NSString * _Nonnull)key;
		[Export("gck_setIntegerValue:forKey:")]
		void Gck_setIntegerValue(nint value, string key);

		// -(void)gck_setUIntegerValue:(NSUInteger)value forKey:(NSString * _Nonnull)key;
		[Export("gck_setUIntegerValue:forKey:")]
		void Gck_setUIntegerValue(nuint value, string key);

		// -(void)gck_setDoubleValue:(double)value forKey:(NSString * _Nonnull)key;
		[Export("gck_setDoubleValue:forKey:")]
		void Gck_setDoubleValue(double value, string key);

		// -(void)gck_setBoolValue:(BOOL)value forKey:(NSString * _Nonnull)key;
		[Export("gck_setBoolValue:forKey:")]
		void Gck_setBoolValue(bool value, string key);
	}

	// @interface GCKAdditions (NSTimer)
	[Category]
	[BaseType(typeof(NSTimer))]
	interface NSTimer_GCKAdditions
	{
		// +(NSTimer * _Nonnull)gck_scheduledTimerWithTimeInterval:(NSTimeInterval)interval weakTarget:(id _Nonnull)target selector:(SEL _Nonnull)selector userInfo:(id _Nullable)userInfo repeats:(BOOL)repeats;
		[Static]
		[Export("gck_scheduledTimerWithTimeInterval:weakTarget:selector:userInfo:repeats:")]
		NSTimer Gck_scheduledTimerWithTimeInterval(double interval, NSObject target, Selector selector, [NullAllowed] NSObject userInfo, bool repeats);
	}

	// @interface GCKApplicationMetadata : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GCKApplicationMetadata : INSCopying
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull applicationID;
		[Export("applicationID")]
		string ApplicationID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull applicationName;
		[Export("applicationName")]
		string ApplicationName { get; }

		// @property (readonly, copy, nonatomic) NSArray<GCKImage *> * _Nullable images;
		[NullAllowed, Export("images", ArgumentSemantic.Copy)]
		GCKImage[] Images { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable namespaces;
		[NullAllowed, Export("namespaces", ArgumentSemantic.Copy)]
		string[] Namespaces { get; }

		// @property (readonly, copy, nonatomic) GCKSenderApplicationInfo * _Nullable senderApplicationInfo;
		[NullAllowed, Export("senderApplicationInfo", ArgumentSemantic.Copy)]
		GCKSenderApplicationInfo SenderApplicationInfo { get; }

		// -(NSString * _Nullable)senderAppIdentifier;
		[NullAllowed, Export("senderAppIdentifier")]
		string SenderAppIdentifier { get; }

		// -(NSURL * _Nullable)senderAppLaunchURL;
		[NullAllowed, Export("senderAppLaunchURL")]
		NSUrl SenderAppLaunchURL { get; }
	}

	// @interface GCKCastChannel : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKCastChannel
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull protocolNamespace;
		[Export("protocolNamespace")]
		string ProtocolNamespace { get; }

		// @property (readonly, assign, nonatomic) BOOL isConnected;
		[Export("isConnected")]
		bool IsConnected { get; }

		// @property (readonly, nonatomic, weak) GCKDeviceManager * _Nullable deviceManager;
		[NullAllowed, Export("deviceManager", ArgumentSemantic.Weak)]
		GCKDeviceManager DeviceManager { get; }

		// -(instancetype _Nonnull)initWithNamespace:(NSString * _Nonnull)protocolNamespace;
		[Export("initWithNamespace:")]
		IntPtr Constructor(string protocolNamespace);

		// -(void)didReceiveTextMessage:(NSString * _Nonnull)message;
		[Export("didReceiveTextMessage:")]
		void DidReceiveTextMessage(string message);

		// -(BOOL)sendTextMessage:(NSString * _Nonnull)message __attribute__((deprecated("Use sendTextMessage:error:")));
		[Export("sendTextMessage:")]
		bool SendTextMessage(string message);

		// -(BOOL)sendTextMessage:(NSString * _Nonnull)message error:(GCKError * _Nullable * _Nullable)error;
		[Export("sendTextMessage:error:")]
		bool SendTextMessage(string message, [NullAllowed] out GCKError error);

		// -(NSInteger)generateRequestID;
		[Export("generateRequestID")]
		nint GenerateRequestID();

		// -(NSNumber * _Nullable)generateRequestNumber;
		[NullAllowed, Export("generateRequestNumber")]
		NSNumber GenerateRequestNumber();

		// -(void)didConnect;
		[Export("didConnect")]
		void DidConnect();

		// -(void)didDisconnect;
		[Export("didDisconnect")]
		void DidDisconnect();
	}

	// @interface GCKAdBreakInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface GCKAdBreakInfo
	{
		// @property (readonly, assign, nonatomic) NSTimeInterval playbackPosition;
		[Export("playbackPosition")]
		double PlaybackPosition { get; }

		// -(instancetype _Nonnull)initWithPlaybackPosition:(NSTimeInterval)playbackPosition;
		[Export("initWithPlaybackPosition:")]
		IntPtr Constructor(double playbackPosition);
	}

	// @interface GCKColor : NSObject <NSCopying, NSCoding>
	[BaseType(typeof(NSObject))]
	interface GCKColor : INSCopying, INSCoding
	{
		// @property (readonly, nonatomic) CGFloat red;
		[Export("red")]
		nfloat Red { get; }

		// @property (readonly, nonatomic) CGFloat green;
		[Export("green")]
		nfloat Green { get; }

		// @property (readonly, nonatomic) CGFloat blue;
		[Export("blue")]
		nfloat Blue { get; }

		// @property (readonly, nonatomic) CGFloat alpha;
		[Export("alpha")]
		nfloat Alpha { get; }

		// -(instancetype _Nonnull)initWithRed:(CGFloat)red green:(CGFloat)green blue:(CGFloat)blue alpha:(CGFloat)alpha;
		[Export("initWithRed:green:blue:alpha:")]
		IntPtr Constructor(nfloat red, nfloat green, nfloat blue, nfloat alpha);

		// -(instancetype _Nonnull)initWithRed:(CGFloat)red green:(CGFloat)green blue:(CGFloat)blue;
		[Export("initWithRed:green:blue:")]
		IntPtr Constructor(nfloat red, nfloat green, nfloat blue);

		// -(instancetype _Nonnull)initWithUIColor:(UIColor * _Nonnull)color;
		[Export("initWithUIColor:")]
		IntPtr Constructor(UIColor color);

		// -(instancetype _Nonnull)initWithCSSString:(NSString * _Nonnull)CSSString;
		[Export("initWithCSSString:")]
		IntPtr Constructor(string CSSString);

		// -(NSString * _Nonnull)CSSString;
		[Export("CSSString")]
		string CSSString { get; }

		// +(GCKColor * _Nonnull)black;
		[Static]
		[Export("black")]
		GCKColor BlackColor { get; }

		// +(GCKColor * _Nonnull)red;
		[Static]
		[Export("red")]
		GCKColor RedColor { get; }

		// +(GCKColor * _Nonnull)green;
		[Static]
		[Export("green")]
		GCKColor GreenColor { get; }

		// +(GCKColor * _Nonnull)blue;
		[Static]
		[Export("blue")]
		GCKColor BlueColor { get; }

		// +(GCKColor * _Nonnull)cyan;
		[Static]
		[Export("cyan")]
		GCKColor CyanColor { get; }

		// +(GCKColor * _Nonnull)magenta;
		[Static]
		[Export("magenta")]
		GCKColor MagentaColor { get; }

		// +(GCKColor * _Nonnull)yellow;
		[Static]
		[Export("yellow")]
		GCKColor YellowColor { get; }

		// +(GCKColor * _Nonnull)white;
		[Static]
		[Export("white")]
		GCKColor WhiteColor { get; }
	}

	// @interface GCKCastSession
	[BaseType(typeof(GCKSession))]
	interface GCKCastSession
	{
		// @property (readonly, assign, nonatomic) int activeInputStatus;
		[Export("activeInputStatus")]
		int ActiveInputStatus { get; }

		// @property (readonly, assign, nonatomic) int standbyStatus;
		[Export("standbyStatus")]
		int StandbyStatus { get; }

		// @property (readonly, copy, nonatomic) GCKApplicationMetadata * applicationMetadata;
		[Export("applicationMetadata", ArgumentSemantic.Copy)]
		GCKApplicationMetadata ApplicationMetadata { get; }

		// -(instancetype)initWithDevice:(GCKDevice *)device sessionID:(NSString *)sessionID castOptions:(GCKCastOptions *)castOptions __attribute__((objc_designated_initializer));
		[Export("initWithDevice:sessionID:castOptions:")]
		[DesignatedInitializer]
		IntPtr Constructor(GCKDevice device, string sessionID, GCKCastOptions castOptions);

		// -(BOOL)addChannel:(GCKCastChannel *)channel;
		[Export("addChannel:")]
		bool AddChannel(GCKCastChannel channel);

		// -(BOOL)removeChannel:(GCKCastChannel *)channel;
		[Export("removeChannel:")]
		bool RemoveChannel(GCKCastChannel channel);

		// -(void)addDeviceStatusListener:(id<GCKCastDeviceStatusListener>)listener;
		[Export("addDeviceStatusListener:")]
		void AddDeviceStatusListener(GCKCastDeviceStatusListener listener);

		// -(void)removeDeviceStatusListener:(id<GCKCastDeviceStatusListener>)listener;
		[Export("removeDeviceStatusListener:")]
		void RemoveDeviceStatusListener(GCKCastDeviceStatusListener listener);

		// -(GCKRequest *)setDeviceVolume:(float)volume forMultizoneDevice:(GCKMultizoneDevice *)device;
		[Export("setDeviceVolume:forMultizoneDevice:")]
		GCKRequest SetDeviceVolume(float volume, GCKMultizoneDevice device);

		// -(GCKRequest *)setDeviceMuted:(BOOL)muted forMultizoneDevice:(GCKMultizoneDevice *)device;
		[Export("setDeviceMuted:forMultizoneDevice:")]
		GCKRequest SetDeviceMuted(bool muted, GCKMultizoneDevice device);

		// -(GCKRequest *)requestMultizoneStatus;
		[Export("requestMultizoneStatus")]
		GCKRequest RequestMultizoneStatus();
	}

	// @interface GCKCastOptions : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface GCKCastOptions : INSCopying
	{
		// -(instancetype _Nonnull)initWithReceiverApplicationID:(NSString * _Nonnull)applicationID;
		[Export("initWithReceiverApplicationID:")]
		IntPtr Constructor(string applicationID);

		// -(instancetype _Nonnull)initWithSupportedNamespaces:(NSArray<NSString *> * _Nonnull)namespaces;
		[Export("initWithSupportedNamespaces:")]
		IntPtr Constructor(string[] namespaces);

		// @property (assign, readwrite, nonatomic) BOOL physicalVolumeButtonsWillControlDeviceVolume;
		[Export("physicalVolumeButtonsWillControlDeviceVolume")]
		bool PhysicalVolumeButtonsWillControlDeviceVolume { get; set; }

		// @property (readwrite, copy, nonatomic) GCKLaunchOptions * _Nullable launchOptions;
		[NullAllowed, Export("launchOptions", ArgumentSemantic.Copy)]
		GCKLaunchOptions LaunchOptions { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable sharedContainerIdentifier;
		[NullAllowed, Export("sharedContainerIdentifier")]
		string SharedContainerIdentifier { get; set; }
	}
}
