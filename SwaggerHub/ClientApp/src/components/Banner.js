import React from 'react';

export const Banner = ({ organizationConfig}) => {

    return (
        <div className="banner-header">
            
            <h1><img src={organizationConfig.displayImage} alt={organizationConfig.displayTag} />{organizationConfig.displayName}</h1>
        </div>
     )

}