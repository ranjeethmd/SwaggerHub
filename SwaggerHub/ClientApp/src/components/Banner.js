import React from 'react';

export const Banner = ({ organizationConfig}) => {

    return (
        <div className="side-bar-header">
            <h1>{organizationConfig.displayName}</h1>
        </div>
     )

}