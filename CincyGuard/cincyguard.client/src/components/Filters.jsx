import { useState } from "react";

function Filters() {

    const [locationEnabled, setLocationEnabled] = useState(false);
    const [heatmapEnabled, setHeatmapEnabled] = useState(false);

    /*test data curently*/const crimeTypes = [
        "Assault",
        "Burglary",
        "Robbery",
        "Theft",
        "Vandalism",
        "Vehicle Theft"
    ];

    return (
        <section className="filters">
            <h2>Filters</h2>

                <div className="filter-section">

                    <div className="toggle-location">
                        <button
                            className={`toggle-btn ${locationEnabled ? "toggled" : ""}`}
                            onClick={() => setLocationEnabled(!locationEnabled)}>
                            <div className="thumb"> </div>
                        </button>

                        <span>Use Current Location</span>
                    </div>

                    <div className="toggle-heatmap">
                        <button
                            className={`toggle-btn ${heatmapEnabled ? "toggled" : ""}`}
                            onClick={() => setHeatmapEnabled(!heatmapEnabled)}>
                            <div className="thumb"> </div>
                        </button>

                        <span>Heatmap</span>
                    </div>

                    <div className="filter-radius">
                        <label>Radius</label>

                        <input
                            type="range"
                            min="1"
                            max="25"
                            defaultValue="5"
                        />
                    </div>

                    <div className="filter-dateRange">
                        <label>Time Range</label>

                        <input
                            type="range"
                            min="1"
                            max="25"
                            defaultValue="5"
                        />
                    </div>

                    <div className="filter-crimeTypes">
                        <label>Crime Types</label>

                        {crimeTypes.map((crime) => (
                            <label key={crime}>
                                <input type="checkbox" />
                                {crime}
                            </label>
                        ))}
                    </div>       
                </div>
        </section>
  );
}

export default Filters;