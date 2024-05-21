import React from 'react';
import { CommonActions } from '@react-navigation/native';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { BottomNavigation } from 'react-native-paper';
import Icon from 'react-native-vector-icons/MaterialCommunityIcons';
// Components
import CenterStackScreen from '../navigation/CenterStack';
import SettingsScreen from '../screens/details';
import Senhas from '../screens/senhas';

const Tab = createBottomTabNavigator();

export default function BottomTab() {
  return (
    <Tab.Navigator
        screenOptions={{
            headerShown: true,
            headerTitle:"QueuePro",
            headerTitleAlign: "center",
            headerTintColor: '#305e96',
            headerTitleStyle: { fontFamily: 'PoppinsMedium',fontSize:28, marginTop:-10 },
            headerStyle: {backgroundColor:'white', height:95},
            tabBarInactiveTintColor: 'gray',            
        }}
        tabBar={({ navigation, state, descriptors, insets }) => (
        <BottomNavigation.Bar
            activeColor='#305e96'
            inactiveColor='white'
            style={{backgroundColor:'#305e96', height:90, borderTopStartRadius:20, borderTopEndRadius:20, borderWidth:10, borderColor:'#305e96'}}
            activeIndicatorStyle={{backgroundColor:'white'}}
            navigationState={state}
            safeAreaInsets={insets}
            onTabPress={({ route, preventDefault }) => {
                const event = navigation.emit({
                type: 'tabPress',
                target: route.key,
                canPreventDefault: true,
                });

                if (event.defaultPrevented) {
                preventDefault();
                } else {
                navigation.dispatch({
                    ...CommonActions.navigate(route.name, route.params),
                    target: state.key,
                });
                }
            }}
            renderIcon={({ route, focused, color }) => {
                const { options } = descriptors[route.key];
                if (options.tabBarIcon) {
                    return options.tabBarIcon({ focused, color:color, size: 24 });
                }

                return null;
            }}
            getLabelText={({ route }) => {
                const { options } = descriptors[route.key];
                const label =
                options.tabBarLabel !== undefined
                    ? options.tabBarLabel
                    : options.title !== undefined
                    ? options.title
                    : route.title;

                return label;
            }}
        />
      )}
      initialRouteName='Central'
    >
      <Tab.Screen
        name="Tickets"
        component={Senhas}
        options={{
          tabBarLabel: 'Senhas',
          tabBarIcon: ({ color, size }) => {
            return <Icon name="ticket-confirmation" size={size} color={color} />;
          },
          tabBarLabelStyle:{color:'white'}
        }}
      />
      <Tab.Screen
        name="Central"
        component={CenterStackScreen}
        style={{color:'blue'}}
        options={{
          tabBarLabel: 'Central',
          tabBarIcon: ({ color, size }) => {
            return <Icon name="view-dashboard" size={size} color={color} />;
          },
        }}
      />
      <Tab.Screen
        name="Settings"
        component={SettingsScreen}
        options={{
          tabBarLabel: 'Definições',
          tabBarIcon: ({ color, size }) => {
            return <Icon name="cog" size={size} color={color} />;
          },
        }}
      />
    </Tab.Navigator>
  );
}