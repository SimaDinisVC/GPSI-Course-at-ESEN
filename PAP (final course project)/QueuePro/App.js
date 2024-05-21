import { useEffect } from 'react';
import { Platform } from 'react-native';
import { PaperProvider } from 'react-native-paper';
import * as SplashScreen from 'expo-splash-screen';
import { useFonts } from 'expo-font';
// React Navigation
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
// Redux
import store from './global/store';
import { Provider as StoreProvider } from 'react-redux';
import { useDispatch } from 'react-redux';
// Components
import MainBottomTab from './components/navigation/MainBottomTab';
import IntroductionScreen from './components/screens/intro';
// Services
import WebSocketService from './services/WebSocketService';

// ---------------------------------------------------------------------------

// prevents the SplashScreen from closing
SplashScreen.preventAutoHideAsync();

const Stack = createNativeStackNavigator();

function App() {
  const dispatch = useDispatch();

  // Loading Fonts
  const [loaded] = useFonts({
    PoppinsRegular: require('./assets/fonts/Poppins-Regular.ttf'),
    PoppinsItalic: require('./assets/fonts/Poppins-Italic.ttf'),
    PoppinsLight: require('./assets/fonts/Poppins-Light.ttf'),
    PoppinsMedium: require('./assets/fonts/Poppins-Medium.ttf'),
    PoppinsBold: require('./assets/fonts/Poppins-Bold.ttf'),
    PoppinsSemiBold: require('./assets/fonts/Poppins-SemiBold.ttf'),
  });

  useEffect(() => {
    // Operations
    WebSocketService.setDispatch(dispatch); // Set the Dispatch to Redux Updates
    WebSocketService.connect();

    const timeoutId = setTimeout(() => {
        SplashScreen.hideAsync();
    }, (1)*1000); // Take 1s 

    return () => {
      clearTimeout(timeoutId);
      WebSocketService.disconnect();
    };
  }, []);

  if (!loaded) { // Prevents the app crash
    return null;
  }

  return (
    <NavigationContainer>
      <Stack.Navigator initialRouteName='intro' screenOptions={Platform.OS === 'android' ? { headerShown: false, statusBarStyle: "dark", statusBarTranslucent: true } : { headerShown: false }}>
        <Stack.Screen name='intro' component={ IntroductionScreen }/>
        <Stack.Screen name='main' component={ MainBottomTab }/>
      </Stack.Navigator>
    </NavigationContainer>
  );
}

export default function Main() {
  return (
    <StoreProvider store={store}>
      <PaperProvider>
        <App/>
      </PaperProvider>
    </StoreProvider>
  );
}