import { createNativeStackNavigator } from '@react-navigation/native-stack';
// Components
import Home from '../screens/home';
import selectCompany from '../screens/selectCompany';
import selectEstablishment from '../screens/selectEstablishment';
import selectSection from '../screens/selectSection';
import agendarTicket from '../screens/agendarSenha';

const Stack = createNativeStackNavigator();

export default function CenterStack({ navigate }) {
    return (
        <Stack.Navigator initialRouteName='Home' screenOptions={{headerShown:false}}>
            <Stack.Screen name='Home' component={Home}/>
            <Stack.Screen name='selectCompany' component={selectCompany}/>
            <Stack.Screen name='selectEstablishment' component={selectEstablishment}/>
            <Stack.Screen name='selectSection' component={selectSection}/>
            <Stack.Screen name='agendarTicket' component={agendarTicket}/>
        </Stack.Navigator>
    );
}