import './App.css';

import Filters from './components/Filters';
import CrimeDetails from './components/CrimeDetails';
import Map from './components/Map';


function App() {
    return (
        <div>
            <header>
                CincyGuard
            </header>
        
            <div className="dashboard-container">

                <div className="left-panel">
                    <Filters />
                    <CrimeDetails />
                </div>
             
                <Map />

            </div>
        
        </div>
    );
}

export default App;